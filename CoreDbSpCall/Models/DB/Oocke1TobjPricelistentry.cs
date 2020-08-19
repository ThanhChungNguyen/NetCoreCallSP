using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1TobjPricelistentry
    {
        public string ObjectId { get; set; }
        public string PParent { get; set; }
        public string Dtype { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public short? AccessLevelDelete { get; set; }
        public int Owner { get; set; }
        public int Objusage { get; set; }
        public decimal? Price { get; set; }
        public short? PriceCurrency { get; set; }
        public int PriceLevel { get; set; }
        public string Description { get; set; }
        public decimal? QuantityFrom { get; set; }
        public decimal? QuantityTo { get; set; }
        public decimal? Discount { get; set; }
        public bool? DiscountIsPercentage { get; set; }
        public string Uom { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public bool? ProductDisabled { get; set; }
        public string Product { get; set; }
        public string SalesTaxType { get; set; }
        public string BasePrice { get; set; }
    }
}
