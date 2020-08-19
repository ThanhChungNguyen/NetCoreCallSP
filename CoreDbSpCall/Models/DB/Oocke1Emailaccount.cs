using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1Emailaccount
    {
        public string ObjectId { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelDelete { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public string IncomingMailServiceName { get; set; }
        public bool? IsDefault { get; set; }
        public int ModifiedBy { get; set; }
        public string OutgoingMailServiceName { get; set; }
        public int Owner { get; set; }
        public string ReplyEMailAddress { get; set; }
        public string PParent { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Dtype { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public string Name { get; set; }
        public string AccessToken { get; set; }
        public string AccessTokenSecret { get; set; }
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string Hostname { get; set; }
        public string Password { get; set; }
        public string Servicename { get; set; }
        public string Username { get; set; }
    }
}
