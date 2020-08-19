using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class SearchFieldVEducationContract
    {
        public string ObjectId { get; set; }
        public DateTime? SearchStudentBirthdate { get; set; }
        public string SearchStudentFirstName { get; set; }
        public string SearchStudentKlassNames { get; set; }
        public string SearchStudentLastName { get; set; }
        public string SearchStudentPostalCity { get; set; }
        public DateTime? SearchSubjectTableActiveOn { get; set; }
        public DateTime? SearchSubjectTableExpiresOn { get; set; }
        public string SearchSubjectTableName { get; set; }
        public string SearchEducationNames { get; set; }
        public string AccountNumber { get; set; }
        public string SearchSubjectTableInternalUnit { get; set; }
        public string SearchSubjectTableObjectId { get; set; }
        public string SearchSubjectTableAssignment { get; set; }
        public string SearchStudentId { get; set; }
    }
}
