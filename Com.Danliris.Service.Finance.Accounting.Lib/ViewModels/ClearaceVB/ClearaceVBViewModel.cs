﻿using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Danliris.Service.Finance.Accounting.Lib.ViewModels.ClearaceVB
{
    public class ClearaceVBViewModel : StandardEntity
    {
        //public long Id { get; set; }
        public string RqstNo { get; set; }
        public string VBCategory { get; set; }
        public DateTimeOffset RqstDate { get; set; }
        public Unit Unit { get; set; }
        public string Appliciant { get; set; }
        public string RealNo { get; set; }
        public DateTimeOffset RealDate { get; set; }
        public DateTimeOffset? VerDate { get; set; }
        public string DiffStatus { get; set; }
        public decimal DiffAmount { get; set; }
        public DateTimeOffset? ClearanceDate { get; set; }
        public bool IsPosted { get; set; }
        public string Status { get; set; }
        //public DateTime LastModifiedUtc { get; set; }
    }
}
