using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACL.XrmToolBox.BulkRecordAssigner.Models
{
    internal class TeamListItem
    {
        public readonly Entity team;

        public TeamListItem(Entity team)
        {
            this.team = team;
        }

        public EntityReference ToEntityReference()
        {
            return team.ToEntityReference();
        }

        public override string ToString()
        {
            return team.GetAttributeValue<string>("name");
        }
    }
}
