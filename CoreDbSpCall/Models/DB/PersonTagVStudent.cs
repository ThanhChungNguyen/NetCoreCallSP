using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class PersonTagVStudent
    {
        public string StudentObjectId { get; set; }
        public string SchoolObjectId { get; set; }
        public DateTime? DeviatingStartDate { get; set; }
        public DateTime? DeviatingEndDate { get; set; }
        public DateTime? CareOfferDeviatingStartDate { get; set; }
        public DateTime? CareOfferDeviatingEndDate { get; set; }
        public DateTime? EducationStartDate { get; set; }
        public DateTime? EducationEndDate { get; set; }
        public string EducationContractObjectId { get; set; }
        public string EducationObjectId { get; set; }
        public bool Disabled { get; set; }
        public string EducationInternalUnit { get; set; }
    }
}
