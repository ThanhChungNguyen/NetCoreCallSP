using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1Filterproperty
    {
        public string ObjectId { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelDelete { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int Owner { get; set; }
        public string PParent { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Dtype { get; set; }
        public int BooleanParam { get; set; }
        public string Clause { get; set; }
        public int DateParam { get; set; }
        public int DateTimeParam { get; set; }
        public int DecimalParam { get; set; }
        public string Description { get; set; }
        public int IntegerParam { get; set; }
        public bool? IsActive { get; set; }
        public string Name { get; set; }
        public int StringParam { get; set; }
        public bool? Disabled { get; set; }
        public short? FilterOperator { get; set; }
        public short? FilterQuantor { get; set; }
        public int SalesTaxType { get; set; }
        public int PriceUom { get; set; }
        public int Classification { get; set; }
        public int Category { get; set; }
        public int Contact { get; set; }
        public int ProcessState { get; set; }
        public int ActivityType { get; set; }
        public int ActivityState { get; set; }
        public int? OffsetInHours { get; set; }
        public int ActivityNumber { get; set; }
        public int ScheduledStart { get; set; }
        public int ScheduledEnd { get; set; }
        public bool? IsMain { get; set; }
        public int AddressType { get; set; }
        public int Objusage { get; set; }
        public int AccountCategory { get; set; }
        public int AccountType { get; set; }
        public int ContractType { get; set; }
        public int TotalAmount { get; set; }
        public int Priority { get; set; }
        public int Supplier { get; set; }
        public int SalesRep { get; set; }
        public int ContractState { get; set; }
        public int Customer { get; set; }
        public int? Account { get; set; }
        public string NamePattern { get; set; }
        public int? DocumentState { get; set; }
        public int? DocumentType { get; set; }
        public int? DocumentFolder { get; set; }
        public int? ContentLanguage { get; set; }
    }
}
