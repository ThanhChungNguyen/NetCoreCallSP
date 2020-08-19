using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class SearchFieldVScheduledCourseV2
    {
        public string ObjectId { get; set; }
        public int? SearchPartyCountF { get; set; }
        public int? SearchPartyCountM { get; set; }
        public int? SearchPartyCountTotal { get; set; }
        public int? SearchProcessState { get; set; }
        public string SearchSubjectTables { get; set; }
        public string SearchSubjectTablesId { get; set; }
        public string SearchEducationLevels { get; set; }
        public string SearchCourseSequences { get; set; }
        public string SearchCourseType { get; set; }
        public string SearchSubjects { get; set; }
        public string SearchSubjectsCode { get; set; }
        public string SearchTeachers { get; set; }
        public string SearchClassName { get; set; }
        public string SearchOfferedCourses { get; set; }
    }
}
