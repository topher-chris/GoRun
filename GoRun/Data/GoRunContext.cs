using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GoRun.Models;

namespace GoRun.Data
{
    public class GoRunContext:DbContext
    {
        public GoRunContext(DbContextOptions<GoRunContext> options)
               : base(options)
        {
        }

        public DbSet<RunningSpot> RunningSpot { get; set; }
        public DbSet<RunningSpot> Rate { get; set; }
    }
}