using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class PersonTagVEmploymentContract
    {
        public string AccountId { get; set; }
        public string SchoolId { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string Contractid { get; set; }
        public bool? Disabled { get; set; }
    }
}
