using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACL.XrmToolBox.BulkRecordAssigner.Helpers
{
    internal class LogHelper
    {
        public static void WriteErrorsToLog(string logName, ExecuteMultipleResponseItemCollection responseCollection, List<EntityReference> targetList)
        {
            using (var sw = File.AppendText(logName))
            {
                foreach (var responseItem in responseCollection)
                {
                    if (responseItem.Fault != null)
                    {
                        var index = responseItem.RequestIndex;

                        sw.WriteLine("----------------");
                        sw.WriteLine("Time Stamp: 	{0}", responseItem.Fault.Timestamp.ToString("dd/MM/yyyy hh:mm:ss"));
                        sw.WriteLine("Target Entity: 	{0}", targetList[index].LogicalName);
                        sw.WriteLine("Target ID: 	{0}", targetList[index].Id.ToString());
                        sw.WriteLine("Message:	{0}", responseItem.Fault.Message);
                    }
                }
            }
        }
    }
}
