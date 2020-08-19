using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class YourIndexedView
    {
        public string ObjectId { get; set; }
        public string Dtype { get; set; }
        public int? OrderIndex { get; set; }
        public DateTime? ValidFrom { get; set; }
        public bool? IsMain { get; set; }
        public string PParent { get; set; }
        public string SearchPostal1AddressLine { get; set; }
        public string SearchPostal1City { get; set; }
        public string SearchPostal1StreetNumber { get; set; }
        public string SearchPostal1Street { get; set; }
        public short? SearchPostal1Country { get; set; }
        public string SearchPostal1PostalCode { get; set; }
        public string SearchPostal1State { get; set; }
        public string Objusage { get; set; }
    }
}
