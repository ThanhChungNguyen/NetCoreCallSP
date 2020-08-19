using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1Valuerange
    {
        public string ObjectId { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelDelete { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public string IdentityPattern { get; set; }
        public int? ModifiedBy { get; set; }
        public string Name { get; set; }
        public int? NextValue { get; set; }
        public int? Owner { get; set; }
        public string PParent { get; set; }
        public string StoragePath { get; set; }
        public string Dtype { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? IncrementValue { get; set; }
        public int? StartValue { get; set; }
        public string SequenceProviderUri { get; set; }
        public bool? Disabled { get; set; }
        public int? Argument { get; set; }
        public int? ObjectType { get; set; }
        public string QueryType { get; set; }
        public bool? HasLeadingZeroes { get; set; }
        public int? Institution { get; set; }
        public bool? IsMandatory { get; set; }
        public bool? IsManual { get; set; }
        public bool? IsNewAfterLastNumber { get; set; }
        public int? NumberOfDigits { get; set; }
        public string NumberPrefix { get; set; }
        public string NumberSuffix { get; set; }
        public string Query { get; set; }
        public string AutonumRestrictToQuery { get; set; }
    }
}
