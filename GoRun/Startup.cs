using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using GoRun.Data;
using Microsoft.EntityFrameworkCore;

namespace GoRun
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddControllersWithViews();
            services.AddDbContext<GoRunContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("GoRunContext3")));
        //   services.AddMvc(option => option.EnableEndpointRouting = false);     //this was added for my datachart
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }



            else
            {
                app.UseStatusCodePagesWithRedirects("/Error/{0}");
              //  app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();


        //    app.UseMvc(routes =>
        //    {
        //        routes.MapRoute(                       //added for the datachart
        //                name: "Home",   //this was set as default...maybe DataChart?
        //                template: "{controller=Home}/{action=Index}/{id?}");  //is Index the page to be displayed?
        //    });                   //end of datachart info

            app.UseEndpoints(endpoints =>                                       
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


                                             
        }
    }
}
