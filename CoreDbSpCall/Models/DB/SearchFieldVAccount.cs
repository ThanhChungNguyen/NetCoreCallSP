using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class SearchFieldVAccount
    {
        public string ObjectId { get; set; }
        public string SearchName { get; set; }
        public string SearchPostal1AddressLine { get; set; }
        public string SearchPostal1City { get; set; }
        public string SearchPostal1StreetNumber { get; set; }
        public string SearchPostal1Street { get; set; }
        public short? SearchPostal1Country { get; set; }
        public string SearchPostal1PostalCode { get; set; }
        public string SearchPostal1State { get; set; }
        public string SearchEmail { get; set; }
        public string SearchPhone { get; set; }
        public string SearchEmails { get; set; }
        public string SearchString0 { get; set; }
        public string SearchString1 { get; set; }
        public string SearchString2 { get; set; }
        public string SearchString5 { get; set; }
        public string SearchString7 { get; set; }
        public string SearchString8 { get; set; }
        public string SearchString9 { get; set; }
        public int HasAddessValid { get; set; }
        public string UserString1 { get; set; }
    }
}
