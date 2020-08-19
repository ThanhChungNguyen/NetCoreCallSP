using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1TobjLnkitemlnkfrom
    {
        public string ObjectId { get; set; }
        public string PParent { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
        public string Dtype { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public short? AccessLevelDelete { get; set; }
        public int Owner { get; set; }
        public bool? Disabled { get; set; }
        public string DisabledReason { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? LinkType { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string LinkTo { get; set; }
        public string LinkFrom { get; set; }
    }
}
