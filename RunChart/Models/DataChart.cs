
using System.ComponentModel.DataAnnotations.Schema;

namespace RunChart.Models
{
    [Table("RunningSpot")]    //maybe DataChart?
    public class RunningSpot
    {
        public string LocationType { get; set; }
        public decimal Rate { get; set; }
    }
}
