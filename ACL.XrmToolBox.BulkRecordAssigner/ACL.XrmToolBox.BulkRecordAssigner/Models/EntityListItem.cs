using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACL.XrmToolBox.BulkRecordAssigner.Models
{
    internal class EntityListItem
    {
        public readonly EntityMetadata Metadata;

        public EntityListItem(EntityMetadata Metadata)
        {
            this.Metadata = Metadata;
        }

        public string LogicalName
        {
            get { return Metadata.LogicalName; }
        }

        public string DisplayName
        {
            get { return Metadata.DisplayName.UserLocalizedLabel.Label; }
        }

        public override string ToString()
        {
            return Metadata.DisplayName.UserLocalizedLabel.Label;
        }
    }
}
