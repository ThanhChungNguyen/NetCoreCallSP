using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Cbeoc1TobjAssessmentposition
    {
        public string ObjectId { get; set; }
        public string PParent { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Dtype { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public short? AccessLevelDelete { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? GradeWeight { get; set; }
        public short? GradeType { get; set; }
        public string OfferedCourse { get; set; }
        public string AssessmentDefinition { get; set; }
        public string InstitutionActivity { get; set; }
        public string AssessmentBase { get; set; }
    }
}
