using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class PersonTagVFunction
    {
        public string AccountId { get; set; }
        public string ContractId { get; set; }
        public string SchoolId { get; set; }
        public string FunctionId { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string FunctionTagCode { get; set; }
        public bool? Disabled { get; set; }
    }
}
