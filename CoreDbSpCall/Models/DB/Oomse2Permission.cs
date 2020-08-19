using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oomse2Permission
    {
        public string ObjectId { get; set; }
        public int Action { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public string Description { get; set; }
        public int ModifiedBy { get; set; }
        public string Name { get; set; }
        public string Privilege { get; set; }
        public string PParent { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Dtype { get; set; }
        public int? LocalizedDescription { get; set; }
        public short? Type { get; set; }
    }
}
