﻿using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1Bookingtemplate
    {
        public string ObjectId { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelDelete { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public string BookingText { get; set; }
        public string BookingTextSuffix { get; set; }
        public short? BookingType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public string PParent { get; set; }
        public string Description { get; set; }
        public int? ModifiedBy { get; set; }
        public string Name { get; set; }
        public int? Owner { get; set; }
        public string PositionCredit { get; set; }
        public string PositionDebit { get; set; }
        public bool? UserBoolean0 { get; set; }
        public bool? UserBoolean1 { get; set; }
        public bool? UserBoolean2 { get; set; }
        public bool? UserBoolean3 { get; set; }
        public int? UserBoolean4 { get; set; }
        public short? UserCode0 { get; set; }
        public short? UserCode1 { get; set; }
        public short? UserCode2 { get; set; }
        public short? UserCode3 { get; set; }
        public int? UserCode4 { get; set; }
        public DateTime? UserDate0 { get; set; }
        public DateTime? UserDate1 { get; set; }
        public DateTime? UserDate2 { get; set; }
        public DateTime? UserDate3 { get; set; }
        public int? UserDate4 { get; set; }
        public DateTime? UserDateTime0 { get; set; }
        public DateTime? UserDateTime1 { get; set; }
        public DateTime? UserDateTime2 { get; set; }
        public DateTime? UserDateTime3 { get; set; }
        public int? UserDateTime4 { get; set; }
        public decimal? UserNumber0 { get; set; }
        public decimal? UserNumber1 { get; set; }
        public decimal? UserNumber2 { get; set; }
        public decimal? UserNumber3 { get; set; }
        public int? UserNumber4 { get; set; }
        public string UserString0 { get; set; }
        public string UserString1 { get; set; }
        public string UserString2 { get; set; }
        public string UserString3 { get; set; }
        public int? UserString4 { get; set; }
        public string Dtype { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool? Disabled { get; set; }
        public string DisabledReason { get; set; }
    }
}
