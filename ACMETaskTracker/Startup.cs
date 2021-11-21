using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ACMETaskTracker.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ACMETaskTracker
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<StoreDbContext>(opts =>
            {
                opts.UseSqlServer(Configuration["ConnectionStrings:AcmeTaskTrackerConnection"]);
            });
            services.AddScoped<IStoreRepository, EFStoreRepository>();
            services.AddDistributedMemoryCache(); // Enables session state
            services.AddSession(); // Enables session state
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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseSession(); // Enables session state
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("catpage",
                    "{category}/Page{productPage:int}",
                    new { Controller = "Home", Action = "Index" });
                endpoints.MapControllerRoute("page",
                    "{category}/Page{productPage:int}",
                    new { Controller = "Home", Action = "Index", productPage = 1 });
                endpoints.MapControllerRoute("category",
                    "{category}",
                    new { Controller = "Home", Action = "Index", productPage = 1 });
                endpoints.MapControllerRoute("pagination",
                    "Products/Page{productPage}",
                    new { Controller = "Home", Action = "Index", productPage = 1 });
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            SeedData.EnsurePopulated(app);
        }
    }
}
