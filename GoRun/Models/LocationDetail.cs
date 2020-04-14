using System;
using System.Collections.Generic;

namespace GoRun.Models
{
    public partial class LocationDetail
    {
        public int? LocationId { get; set; }
        public string LocationName { get; set; }
        public string TimeOpen { get; set; }
        public string Inclines { get; set; }
        public string Coordinates { get; set; }
        public string Bathrooms { get; set; }
    }
}
