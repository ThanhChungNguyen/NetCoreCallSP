using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class PersonTagVClassInstructor
    {
        public string TeacherObjectId { get; set; }
        public string SchoolObjectId { get; set; }
        public string ClassObjectId { get; set; }
        public DateTime? ClassStartAt { get; set; }
        public DateTime? ClassEndAt { get; set; }
        public bool? Disabled { get; set; }
        public short? Role { get; set; }
    }
}
