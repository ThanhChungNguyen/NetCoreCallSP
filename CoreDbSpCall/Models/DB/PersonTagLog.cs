using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class PersonTagLog
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
