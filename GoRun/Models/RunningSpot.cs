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
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal LocationAddress { get; set; }
    }
}
