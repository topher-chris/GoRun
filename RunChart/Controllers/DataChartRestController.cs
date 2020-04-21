using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RunChart.Models;

namespace RunChart.Controllers
{
    public class DataChartRestController : Controller
    {
        private DataContext db = new DataContext();

        [HttpGet("findall")]
        [Produces("application/json")]
        public async Task<IActionResult> findAll()
        {
            try
            {
                var datacharts = db.RunningSpot.ToList();
                return Ok(datacharts);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}