using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1TobjAggrdepotrepitem
    {
        public string ObjectId { get; set; }
        public string PParent { get; set; }
        public string Dtype { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public short? AccessLevelDelete { get; set; }
        public int Owner { get; set; }
        public string BookingPeriod { get; set; }
        public string BookingPeriodName { get; set; }
        public string PositionName { get; set; }
        public decimal? SumBalance { get; set; }
        public decimal? SumBalanceBop { get; set; }
        public decimal? SumBalanceCredit { get; set; }
        public decimal? SumBalanceCreditBop { get; set; }
        public decimal? SumBalanceDebit { get; set; }
        public decimal? SumBalanceDebitBop { get; set; }
        public decimal? SumBalanceSimple { get; set; }
        public decimal? SumBalanceSimpleBop { get; set; }
    }
}
