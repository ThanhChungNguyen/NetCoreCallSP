using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oomse2Authenticationcontext
    {
        public string ObjectId { get; set; }
        public short? Completion { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public string Realm { get; set; }
        public string PParent { get; set; }
        public string Subject { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Dtype { get; set; }
    }
}
