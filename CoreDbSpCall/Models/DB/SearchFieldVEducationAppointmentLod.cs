using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class SearchFieldVEducationAppointmentLod
    {
        public string ObjectId { get; set; }
        public string Name { get; set; }
        public string SearchSubjectTablesId { get; set; }
        public string SearchSubjectTables { get; set; }
        public int? TotalParticipants { get; set; }
        public int? TotalParticipantsTeachers { get; set; }
        public int? NotJoinPresenceUnscriptionParticipantsTeachers { get; set; }
        public int? NotJoinPresenceUnscriptionParticipants { get; set; }
        public string InternalUnit { get; set; }
        public bool? TrackStudentAbsences { get; set; }
        public bool? TrackStudentPresences { get; set; }
        public bool? TrackTeacherWorkRecords { get; set; }
        public string CheckParticipantPresenceStatus { get; set; }
        public string SearchString0 { get; set; }
        public string SearchString8 { get; set; }
        public string SearchString5 { get; set; }
        public string SearchString6 { get; set; }
        public string SearchString9 { get; set; }
    }
}
