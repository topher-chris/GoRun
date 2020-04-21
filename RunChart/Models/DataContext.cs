using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;


namespace RunChart.Models
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json");
        var configuration = builder.Build();
        optionsBuilder.UseSqlServer(configuration
            ["ConnectionStrings:GoRunContext3"]);
    }
    public DbSet<RunningSpot> RunningSpot { get; set; }    //it did not work when i had RunningSpot in the <>
    }
}