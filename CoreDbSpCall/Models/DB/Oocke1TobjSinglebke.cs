using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1TobjSinglebke
    {
        public string ObjectId { get; set; }
        public string PParent { get; set; }
        public string Dtype { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelDelete { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public DateTime? BookingDate { get; set; }
        public string Origin { get; set; }
        public short? BookingStatus { get; set; }
        public short? BookingType { get; set; }
        public string BookingText { get; set; }
        public string Cb { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public string Depot { get; set; }
        public string DepotEntity { get; set; }
        public string DepotHolder { get; set; }
        public string Description { get; set; }
        public int ModifiedBy { get; set; }
        public string Name { get; set; }
        public int? OriginContextParams { get; set; }
        public int? OriginContext { get; set; }
        public int Owner { get; set; }
        public string Position { get; set; }
        public string SingleBooking { get; set; }
        public DateTime? ValueDate { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public decimal? QuantityDebit { get; set; }
        public decimal? QuantityCredit { get; set; }
    }
}
