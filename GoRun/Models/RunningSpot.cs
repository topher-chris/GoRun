using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GoRun.Models
{
    public class RunningSpot
    {
        public int Id { get; set; }
        public string LocationName { get; set; }

        [DataType(DataType.Date)]
        public DateTime SubmissionDate { get; set; }
        public string LocationType { get; set; }
        public decimal Rate { get; set; }
    }
}
