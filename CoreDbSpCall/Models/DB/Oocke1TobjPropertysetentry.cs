using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1TobjPropertysetentry
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
        public string PropertyName { get; set; }
        public string PropertyDescription { get; set; }
        public string PropertySetName { get; set; }
        public string PropertySetDescription { get; set; }
        public string StringValue { get; set; }
        public int? IntegerValue { get; set; }
        public bool? BooleanValue { get; set; }
        public string UriValue { get; set; }
        public decimal? DecimalValue { get; set; }
        public string ReferenceValue { get; set; }
        public DateTime? DateValue { get; set; }
        public DateTime? DateTimeValue { get; set; }
        public string Property { get; set; }
    }
}
