using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class SearchFieldVClass
    {
        public string ObjectId { get; set; }
        public DateTime? SearchKlassEndAt { get; set; }
        public DateTime? SearchKlassStartAt { get; set; }
        public int? SearchMemberCountM { get; set; }
        public int? SearchMemberCountF { get; set; }
        public int SearchMemberCountTotal { get; set; }
        public string SearchKlassType { get; set; }
        public int? SearchKlassState { get; set; }
        public string SearchEducationLevels { get; set; }
        public string SearchCourseSequences { get; set; }
        public string SearchTeachers { get; set; }
        public string SearchString0 { get; set; }
        public string SearchSubjectTables { get; set; }
    }
}
