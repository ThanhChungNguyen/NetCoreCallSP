using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class SearchFieldVAssessmentDefinition
    {
        public string ObjectId { get; set; }
        public short? SearchAssessmentActivityState { get; set; }
        public string SearchCourseSequence { get; set; }
        public string SearchEducationLevel { get; set; }
        public string SearchOfferedCourse { get; set; }
        public string SearchSubjectTable { get; set; }
        public DateTime? SearchSubjectTableActiveOn { get; set; }
        public DateTime? SearchSubjectTableExpiresOn { get; set; }
        public bool? SearchSubjectTableTrackAssessments { get; set; }
        public DateTime? SearchPeriodStartAt { get; set; }
        public DateTime? SearchPeriodEndAt { get; set; }
        public string SearchClassName { get; set; }
        public string SearchSchoolName { get; set; }
    }
}
