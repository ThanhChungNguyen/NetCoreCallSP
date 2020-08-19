using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class SearchFieldVContact
    {
        public string ObjectId { get; set; }
        public string SearchContractTypes { get; set; }
        public string SearchQualificationTypes { get; set; }
        public string SearchSubjectTables { get; set; }
        public string SearchOrganisationNames { get; set; }
        public string SearchCourseSequences { get; set; }
    }
}
