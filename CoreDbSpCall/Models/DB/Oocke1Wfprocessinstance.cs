using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1Wfprocessinstance
    {
        public string ObjectId { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelDelete { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public bool? Failed { get; set; }
        public DateTime? LastActivityOn { get; set; }
        public int ModifiedBy { get; set; }
        public int Owner { get; set; }
        public string Parent { get; set; }
        public string Process { get; set; }
        public DateTime? StartedOn { get; set; }
        public int? StepCounter { get; set; }
        public string TargetObject { get; set; }
        public string PParent { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Dtype { get; set; }
        public string Name { get; set; }
    }
}
