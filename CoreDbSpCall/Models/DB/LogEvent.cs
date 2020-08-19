using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class LogEvent
    {
        public long Id { get; set; }
        public string ProcessId { get; set; }
        public string EventType { get; set; }
        public string Xmldata { get; set; }
        public int? Duration { get; set; }
        public string Sqlcaused { get; set; }
        public string Sqlblocked { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
