using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class IndexLogs
    {
        public long Id { get; set; }
        public string IndexName { get; set; }
        public string TableName { get; set; }
        public int? FillFactorValue { get; set; }
        public double? AvgfragmentationPercent { get; set; }
        public double? PageCount { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
