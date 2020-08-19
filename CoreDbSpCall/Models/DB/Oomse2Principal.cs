using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oomse2Principal
    {
        public string ObjectId { get; set; }
        public int AuthCredential { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public string Credential { get; set; }
        public string Description { get; set; }
        public bool? Disabled { get; set; }
        public int IsMemberOf { get; set; }
        public int ModifiedBy { get; set; }
        public string Name { get; set; }
        public string PParent { get; set; }
        public string Subject { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Dtype { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public int GrantedRole { get; set; }
        public bool? IsFinal { get; set; }
        public int? LocalizedDescription { get; set; }
        public short? Type { get; set; }
    }
}
