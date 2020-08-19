using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class PersonTagVParentRelationship
    {
        public string AccountId { get; set; }
        public string ChildAccountId { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string ObjectId { get; set; }
        public bool Disabled { get; set; }
    }
}
