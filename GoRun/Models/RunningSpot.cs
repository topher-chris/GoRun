using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GoRun.Models
{
    public partial class RunningSpot
    {
        public int Id { get; set; }
        public string LocationName { get; set; }

        [DataType(DataType.Date)]
        public DateTime SubmissionDate { get; set; }
        public string LocationType { get; set; }
        public decimal Rate { get; set; }
    }
}
