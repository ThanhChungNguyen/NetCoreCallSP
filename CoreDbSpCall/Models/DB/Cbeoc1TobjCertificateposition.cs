using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Cbeoc1TobjCertificateposition
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
        public string Certificate { get; set; }
        public string CertificateDefinition { get; set; }
        public string CertificateDefinitionName { get; set; }
        public string CertificateCalculator { get; set; }
        public string CertificateCalculatorName { get; set; }
        public string CertificateCalculatorField { get; set; }
        public string CertificateCalculatorFieldName { get; set; }
        public bool? IsCalculatorInputField { get; set; }
        public string CertificateCalculatorFieldId { get; set; }
        public string AssessmentDefinition { get; set; }
        public string AssessmentDefinitionName { get; set; }
        public DateTime? AssessmentDefinitionModifiedAt { get; set; }
        public bool? ZeroAsNullForCalculatedGrade { get; set; }
        public decimal? GradeRounding { get; set; }
        public decimal? GradeRounding2 { get; set; }
        public string AssessmentResult { get; set; }
    }
}
