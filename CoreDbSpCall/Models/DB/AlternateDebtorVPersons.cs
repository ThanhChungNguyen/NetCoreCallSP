using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class AlternateDebtorVPersons
    {
        public string PersonObjectId { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? YearOlds { get; set; }
        public string AltDebtorObjectId { get; set; }
    }
}
