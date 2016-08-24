using ACL.XrmToolBox.BulkRecordAssigner.Models;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACL.XrmToolBox.BulkRecordAssigner.Helpers
{
    internal class CrmHelper
    {
        /// <summary>
        ///     Gets all entities metadata that are user/team owned.
        /// </summary>
        /// <param name="service">The organization service.</param>
        /// <returns>List of entities metadata.</returns>
        public static List<EntityListItem> GetAllEntities(IOrganizationService service)
        {
            var entities = new List<EntityListItem>();

            var request = new RetrieveAllEntitiesRequest
            {
                EntityFilters = EntityFilters.Entity
            };

            var response = (RetrieveAllEntitiesResponse)service.Execute(request);

            foreach (EntityMetadata em in response.EntityMetadata)
            {
                if (em.DisplayName.UserLocalizedLabel != null && em.OwnershipType == OwnershipTypes.UserOwned)
                {
                    entities.Add(new EntityListItem(em));
                }
            }

            return entities;
        }


        /// <summary>
        ///     Gets all active system users.
        /// </summary>
        /// <param name="service">The organization service.</param>
        /// <returns>List of entities of system user.</returns>
        public static List<UserListItem> GetAllUsers(IOrganizationService service)
        {
            var query = new QueryExpression("systemuser")
            {
                ColumnSet = new ColumnSet(
                    "domainname",
                    "fullname"),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("isdisabled", ConditionOperator.Equal, false)
                    }
                },
                Orders =
                {
                    new OrderExpression("domainname", OrderType.Ascending)
                },
            };

            var results = service.RetrieveMultiple(query);

            return results.Entities.Select(e => new UserListItem(e))
                .ToList();
        }

        /// <summary>
        ///     Gets all active teams.
        /// </summary>
        /// <param name="service">The organization service.</param>
        /// <returns>List team combo box items.</returns>
        public static List<TeamListItem> GetAllTeams(IOrganizationService service)
        {
            var query = new QueryExpression("team")
            {
                ColumnSet = new ColumnSet("name"),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("teamtype", ConditionOperator.Equal, 0)
                    }
                },
                Orders =
                {
                    new OrderExpression("name", OrderType.Ascending)
                },
            };

            var results = service.RetrieveMultiple(query);

            return results.Entities.Select(e => new TeamListItem(e))
                .ToList();
        }

        /// <summary>
        ///     Get the target records.
        /// </summary>
        /// <param name="service">The CRM organization service.</param>
        /// <param name="enityLogicalName">The entity logical name.</param>
        /// <param name="assignee">The assignee.</param>
        /// <param name="currentOwners">The list of current owners.</param>
        /// <returns>List of entity references.</returns>
        public static List<EntityReference> GetTargetRecords(IOrganizationService service, string enityLogicalName, 
            EntityReference assignee, List<EntityReference> currentOwners)
        {
            var query = new QueryExpression(enityLogicalName)
            {
                ColumnSet = new ColumnSet(false),
                PageInfo = new PagingInfo
                {
                    Count = 5000,
                    PageNumber = 1,
                    ReturnTotalRecordCount = true
                },
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("ownerid", ConditionOperator.NotEqual, assignee.Id),
                        new ConditionExpression("ownerid", ConditionOperator.In, currentOwners.Select(o => o.Id).ToArray())
                    }
                }
            };

            var results = new EntityCollection();

            while (true)
            {
                var pageResults = service.RetrieveMultiple(query);

                if (pageResults.Entities.Count > 0)
                    results.Entities.AddRange(pageResults.Entities);

                if (pageResults.MoreRecords)
                {
                    query.PageInfo.PageNumber++;
                    query.PageInfo.PagingCookie = pageResults.PagingCookie;
                }
                else
                {
                    break;
                }
            }

            return results.Entities.Select(r => r.ToEntityReference()).ToList();
        }

        /// <summary>
        ///     Assign the bacth of target records to the assignee.
        /// </summary>
        /// <param name="service">The organization service.</param>
        /// <param name="assignee">The assignee entity reference.</param>
        /// <param name="targetBatch">The list of target entity references.</param>
        /// <returns>The execute multiple response.</returns>
        public static ExecuteMultipleResponse AssignBatchOfTargetRecords(IOrganizationService service, 
            EntityReference assignee, List<EntityReference> targetBatch)
        {
            var multipleRequest = new ExecuteMultipleRequest
            {
                Settings = new ExecuteMultipleSettings
                {
                    ContinueOnError = true, // TODO: Add to options
                    ReturnResponses = true
                },
                Requests = new OrganizationRequestCollection()
            };

            foreach (var target in targetBatch)
            {
                var assignRequest = new AssignRequest
                {
                    Assignee = assignee,
                    Target = target
                };
                multipleRequest.Requests.Add(assignRequest);
            }
            
            return (ExecuteMultipleResponse)service.Execute(multipleRequest);
        }
    }
}
