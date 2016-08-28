using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACL.XrmToolBox.BulkRecordAssigner.Models
{
    internal class UserListItem
    {
        public readonly Entity user;

        public UserListItem(Entity user)
        {
            this.user = user;
        }

        public EntityReference ToEntityReference()
        {
            return user.ToEntityReference();
        }

        public override string ToString()
        {
            var name = user.GetAttributeValue<string>("fullname");
            var disabled = user.GetAttributeValue<bool>("isdisabled");

            if (disabled)
            {
                name += " (Disabled)";
            }

            return name;
        }
    }
}
