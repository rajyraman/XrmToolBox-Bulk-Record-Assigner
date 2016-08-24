using ACL.XrmToolBox.BulkRecordAssigner.Helpers;
using ACL.XrmToolBox.BulkRecordAssigner.Models;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Args;
using XrmToolBox.Extensibility.Interfaces;

namespace ACL.XrmToolBox.BulkRecordAssigner
{
    public partial class BulkRecordAssigner : PluginControlBase, IStatusBarMessenger, IGitHubPlugin, IHelpPlugin
    {

        public BulkRecordAssigner()
        {
            InitializeComponent();
        }

        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;
        
        private void loadCrmDataButton_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadCrmData);
        }

        private void closeTabButton_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            ExecuteMethod(AssignRecords);
        }

        private void LoadCrmData()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "",
                Work = (w, e) =>
                {
                    // Populate entity combo box
                    w.ReportProgress(0, "Loading entities...");
                    var entityItems = CrmHelper.GetAllEntities(Service);
                    entityComboBox.Items.Clear();
                    entityComboBox.Items.AddRange(entityItems.ToArray());

                    // Load & populate user data
                    w.ReportProgress(33, "Loading users...");
                    var userItems = CrmHelper.GetAllUsers(Service);
                    usersCheckedListBox.Items.Clear();
                    usersCheckedListBox.Items.AddRange(userItems.ToArray());
                    assigneeUserComboBox.Items.Clear();
                    assigneeUserComboBox.Items.AddRange(userItems.ToArray());

                    // Load & populate team data
                    w.ReportProgress(66, "Loading teams...");
                    var teamItems = CrmHelper.GetAllTeams(Service);
                    teamsCheckedListBox.Items.Clear();
                    teamsCheckedListBox.Items.AddRange(teamItems.ToArray());
                    assigneeTeamComboBox.Items.Clear();
                    assigneeTeamComboBox.Items.AddRange(teamItems.ToArray());

                    // Reset progress
                    w.ReportProgress(0, "");
                },
                PostWorkCallBack = e => {},
                ProgressChanged = e =>
                {
                    SetWorkingMessage(e.UserState.ToString());

                    if (SendMessageToStatusBar != null)
                        SendMessageToStatusBar(this, new StatusBarMessageEventArgs(e.ProgressPercentage, e.UserState.ToString()));
                }
            });
        }

        private void AssignRecords()
        {
            // Validate user input
            if (entityComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an entity to asign.");
                return;
            }

            if (usersCheckedListBox.CheckedItems.Count == 0 && teamsCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select an owner to assign from.");
                return;
            }

            if (assigneeUserComboBox.SelectedIndex == -1 && assigneeTeamComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an assignee to assign to.");
                return;
            }

            var targetEntityName = ((EntityListItem)entityComboBox.SelectedItem).LogicalName;

            // Get selected current owners
            var selectedCurrentOwners = new List<EntityReference>();
            selectedCurrentOwners.AddRange(usersCheckedListBox.CheckedItems.Cast<UserListItem>().Select(u => u.ToEntityReference()));
            selectedCurrentOwners.AddRange(teamsCheckedListBox.CheckedItems.Cast<TeamListItem>().Select(t => t.ToEntityReference()));

            // Get selected assignee
            EntityReference selectedAssignee = null;
            if (assigneeTypeUserRadioButton.Checked)
                selectedAssignee = ((UserListItem)assigneeUserComboBox.SelectedItem).ToEntityReference();
            else if (assigneeTypeTeamRadioButton.Checked)
                selectedAssignee = ((TeamListItem)assigneeTeamComboBox.SelectedItem).ToEntityReference();


            WorkAsync(new WorkAsyncInfo
            {
                Message = "Gathering...",
                Work = (w, e) =>
                {
                    // Setup log file
                    var logName = string.Format("{0}\\Bulk Assign Log {1}.txt", logLocationTextBox.Text, DateTime.Now.ToString("yyyMMddhhmmss"));

                    var progressCount = 0;
                    var successCount = 0;
                    var failureCount = 0;

                    // Get the target records to be assigned
                    var targetRecords = CrmHelper.GetTargetRecords(Service, targetEntityName, selectedAssignee, selectedCurrentOwners);
                    
                    var batchSize = Decimal.ToInt32(batchSizeNumbericUpDown.Value);
                    var group = targetRecords.Select((x, index) => new { x, index }).GroupBy(x => x.index / batchSize, y => y.x);

                    foreach (var targetBatch in group)
                    {
                        // Assign the batch of targets to the assignee
                        var response = CrmHelper.AssignBatchOfTargetRecords(Service, selectedAssignee, targetBatch.ToList());

                        // Increment counters
                        progressCount += targetBatch.Count();
                        successCount += response.Responses.Count(r => r.Response != null);
                        failureCount += response.Responses.Count(r => r.Fault != null);

                        // Report progress to ui
                        var progress = (int)Math.Round((double)(100 * progressCount) / targetRecords.Count);
                        var messageBoxString = string.Format("Assigning...{0}{1}/{2}",
                            Environment.NewLine, progressCount, targetRecords.Count);
                        w.ReportProgress(progress, messageBoxString);

                        // Write errors to log file
                        if (response.Responses.Count(r => r.Fault != null) > 0)
                        {
                            LogHelper.WriteErrorsToLog(logName, response.Responses, targetRecords);
                        }
                    }

                    e.Result = new ResultSummary
                    {
                        SuccessCount = successCount,
                        FailureCount = failureCount
                    };
                },
                PostWorkCallBack = e =>
                {
                    MessageBox.Show(
                        string.Format("Bulk Assign Summary{0}{0}Sucesses: {1}{0}Failures: {2}",
                        Environment.NewLine,
                        ((ResultSummary)e.Result).SuccessCount,
                        ((ResultSummary)e.Result).FailureCount));
                },
                ProgressChanged = e =>
                {
                    SetWorkingMessage(e.UserState.ToString());

                    if (SendMessageToStatusBar != null)
                        SendMessageToStatusBar(this, new StatusBarMessageEventArgs(e.ProgressPercentage, string.Format("{0}%", e.ProgressPercentage)));
                },
                IsCancelable = false
            });
        }

        private void rdoAssigneeTypeUser_CheckedChanged(object sender, EventArgs e)
        {
            if (assigneeTypeUserRadioButton.Checked)
            {
                assigneeUserComboBox.SelectedIndex = -1;
                assigneeUserComboBox.Visible = true;

                assigneeTeamComboBox.SelectedIndex = -1;
                assigneeTeamComboBox.Visible = false;
            }
        }

        private void rdoAssigneeTypeTeam_CheckedChanged(object sender, EventArgs e)
        {
            if (assigneeTypeTeamRadioButton.Checked)
            {
                assigneeUserComboBox.SelectedIndex = -1;
                assigneeUserComboBox.Visible = false;

                assigneeTeamComboBox.SelectedIndex = -1;
                assigneeTeamComboBox.Visible = true;
            }
        }

        private void btnBrowseLogLocation_Click(object sender, EventArgs e)
        {
            var fbDialog = new FolderBrowserDialog
            {
                Description = "Select the location the log file will be written to.",
                ShowNewFolderButton = true,
                SelectedPath =  logLocationTextBox.Text
            };

            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                logLocationTextBox.Text = fbDialog.SelectedPath;
            }
        }

        private void BulkRecordAssigner_Load(object sender, EventArgs e)
        {
            logLocationTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        #region Github implementation
        public string RepositoryName
        {
            get { return "XrmToolBox-Bulk-Record-Assigner"; }
        }

        public string UserName
        {
            get { return "AdaptableConsulting"; }
        }
        #endregion Github implementation

        #region Help implementation
        public string HelpUrl
        {
            get { return "https://github.com/AdaptableConsulting/XrmToolBox-Bulk-Record-Assigner/wiki"; }
        }

        #endregion Help implementation

        private void userSelectAllLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < usersCheckedListBox.Items.Count; i++)
            {
                usersCheckedListBox.SetItemChecked(i, true);
            }
        }

        private void userClearSelectionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < usersCheckedListBox.Items.Count; i++)
            {
                usersCheckedListBox.SetItemChecked(i, false);
            }
        }

        private void teamSelectAllLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < teamsCheckedListBox.Items.Count; i++)
            {
                teamsCheckedListBox.SetItemChecked(i, true);
            }
        }

        private void teamClearSelectionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < teamsCheckedListBox.Items.Count; i++)
            {
                teamsCheckedListBox.SetItemChecked(i, false);
            }
        }
    }
}
