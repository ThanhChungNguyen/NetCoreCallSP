﻿using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1Additionalextlink
    {
        public string ObjectId { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelDelete { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public string PParent { get; set; }
        public string ExternalLink { get; set; }
        public int ModifiedBy { get; set; }
        public int Owner { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Dtype { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}
