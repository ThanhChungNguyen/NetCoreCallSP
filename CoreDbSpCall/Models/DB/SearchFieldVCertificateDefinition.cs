using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class SearchFieldVCertificateDefinition
    {
        public string ObjectId { get; set; }
        public string SearchCourseSequence { get; set; }
        public string SearchEducationLevel { get; set; }
        public string SearchSubjectTable { get; set; }
        public DateTime? SearchDateTime0 { get; set; }
        public DateTime? SearchDateTime1 { get; set; }
        public string SearchSchoolXri { get; set; }
        public bool? SearchSubjectTableTrackStudentAssessments { get; set; }
    }
}
