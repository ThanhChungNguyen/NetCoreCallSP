using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1Userhome
    {
        public string ObjectId { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelDelete { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public string Contact { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int Owner { get; set; }
        public string PrimaryGroup { get; set; }
        public string PParent { get; set; }
        public string SendMailSubjectPrefix { get; set; }
        public string Settings { get; set; }
        public bool? StoreSettingsOnLogoff { get; set; }
        public string WebAccessUrl { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Dtype { get; set; }
    }
}
