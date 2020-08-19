using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class PersonTagChange
    {
        public int Id { get; set; }
        public string TagCode { get; set; }
        public string TableCode { get; set; }
        public string ObjectId { get; set; }
        public DateTime DateInserted { get; set; }
        public string State { get; set; }
    }
}
