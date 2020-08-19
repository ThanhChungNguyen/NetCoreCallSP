using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class PersonTagVApprenticeTrainer
    {
        public string AccountId { get; set; }
        public string ContractId { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public short? Role { get; set; }
        public int Disabled { get; set; }
    }
}
