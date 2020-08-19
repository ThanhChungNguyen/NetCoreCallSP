using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1Calendarfeed
    {
        public string ObjectId { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelDelete { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public string PParent { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public int ModifiedBy { get; set; }
        public string Name { get; set; }
        public int Owner { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string Dtype { get; set; }
        public string ActivityFilter { get; set; }
        public string ActivityGroup { get; set; }
        public string BackColor { get; set; }
        public string Color { get; set; }
        public string AccountGroup { get; set; }
        public bool? AllowAddDelete { get; set; }
        public bool? AllowChange { get; set; }
        public string DocumentFolder { get; set; }
        public string DocumentFilter { get; set; }
    }
}
