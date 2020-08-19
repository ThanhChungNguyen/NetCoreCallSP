using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oomse2Credential
    {
        public string ObjectId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public string Id { get; set; }
        public bool? Locked { get; set; }
        public int ModifiedBy { get; set; }
        public int ResetCredential { get; set; }
        public string PParent { get; set; }
        public string Subject { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Dtype { get; set; }
        public string Passwd { get; set; }
        public string Address { get; set; }
        public short? Template { get; set; }
    }
}
