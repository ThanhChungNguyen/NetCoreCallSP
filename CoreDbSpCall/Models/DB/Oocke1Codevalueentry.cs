using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1Codevalueentry
    {
        public string ObjectId { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelDelete { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public string EntryValue { get; set; }
        public int ModifiedBy { get; set; }
        public int Owner { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string PParent { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Dtype { get; set; }
        public string BackColor { get; set; }
        public string Color { get; set; }
        public string FontWeight { get; set; }
        public string IconKey { get; set; }
        public int LongText { get; set; }
        public int ShortText { get; set; }
        public int? OrderIndex { get; set; }
        public int? DecimalPlaces { get; set; }
        public int? DefaultValue { get; set; }
        public string FieldFormat { get; set; }
        public string FieldGroup { get; set; }
        public string FieldType { get; set; }
        public bool? IsDisabled { get; set; }
        public bool? IsHidden { get; set; }
        public bool? IsMultiValue { get; set; }
        public bool? IsReadOnly { get; set; }
        public bool? IsRequired { get; set; }
        public bool? IsUnique { get; set; }
        public int? MaxChars { get; set; }
        public int? MaxRows { get; set; }
        public decimal? MaxValue { get; set; }
        public decimal? MinValue { get; set; }
        public string ObjectType { get; set; }
        public string StoragePath { get; set; }
        public string ValueRange { get; set; }
        public string BfsDiplomaType { get; set; }
        public string ParentCategory { get; set; }
        public string PersonnelCategory { get; set; }
        public int? SalaryGradeFrom { get; set; }
        public int? SalaryGradeTo { get; set; }
        public int? SalaryLevelFrom { get; set; }
        public int? SalaryLevelTo { get; set; }
        public int? ExternalLink { get; set; }
    }
}
