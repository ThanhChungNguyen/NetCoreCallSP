﻿using System;
using System.Collections.Generic;

namespace CoreDbSpCall.Models.DB
{
    public partial class Oocke1Timer
    {
        public string ObjectId { get; set; }
        public short? AccessLevelBrowse { get; set; }
        public short? AccessLevelDelete { get; set; }
        public short? AccessLevelUpdate { get; set; }
        public int? Action { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public string Description { get; set; }
        public bool? Disabled { get; set; }
        public DateTime? LastTriggerAt { get; set; }
        public int? ModifiedBy { get; set; }
        public string Name { get; set; }
        public int? Owner { get; set; }
        public string Target { get; set; }
        public DateTime? TimerEndAt { get; set; }
        public DateTime? TimerStartAt { get; set; }
        public short? TimerState { get; set; }
        public int? TriggerIntervalMinutes { get; set; }
        public int? TriggerRepeat { get; set; }
        public string PParent { get; set; }
        public string Dtype { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
