using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RunChart.Controllers
{
  [Route("datachart")]    //example has lower case so most likely not the sql data table
 public class DataChartController : Controller
 {
     [Route("")]
     [Route("index")]
     [Route("~/")]
     public IActionResult Index()
     {
         return View();
        }
    }
}