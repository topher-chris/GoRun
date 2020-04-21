using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace GoRun.Models
{
    public class DataChart
    {
        public string LocationName { get; set; }
        public decimal Rate { get; set; }
        

    }
}