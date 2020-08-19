using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class CertificateVMissingGrade
    {
        public string CertificateDefinitionId { get; set; }
        public string AssessmentDefinitionId { get; set; }
        public string MissingGradeMarker { get; set; }
        public string PersonId { get; set; }
        public short? GradeType { get; set; }
    }
}
