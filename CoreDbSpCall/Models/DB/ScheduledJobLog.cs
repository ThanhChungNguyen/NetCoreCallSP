using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class ScheduledJobLog
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public string Level { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public string Activity { get; set; }
        public string Logger { get; set; }
        public string Exception { get; set; }
    }
}
