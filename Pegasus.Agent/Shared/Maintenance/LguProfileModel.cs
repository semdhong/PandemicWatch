﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pegasus.Agent.Shared.Maintenance
{
    public class LguProfileModel
    {
        public int Id { get; set; }
        public string LguName { get; set; }
        public string LguAddress { get; set; }
        public string LguLocation { get; set; }
        public string LguLogoPath { get; set; }
        public string LguQrCode { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
