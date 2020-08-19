using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1Subscription
    {
        public string ObjectId { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelDelete { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public string Description { get; set; }
        public int EventType { get; set; }
        public string FilterName0 { get; set; }
        public string FilterName1 { get; set; }
        public string FilterName2 { get; set; }
        public string FilterName3 { get; set; }
        public string FilterName4 { get; set; }
        public int FilterValue0 { get; set; }
        public int FilterValue1 { get; set; }
        public int FilterValue2 { get; set; }
        public int FilterValue3 { get; set; }
        public int FilterValue4 { get; set; }
        public bool? IsActive { get; set; }
        public int ModifiedBy { get; set; }
        public string Name { get; set; }
        public int Owner { get; set; }
        public string Topic { get; set; }
        public string PParent { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Dtype { get; set; }
    }
}
