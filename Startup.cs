using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql;
using WebGame.Data;
using WebGame.Models.WebGame;
using static WebGame.Models.WebGame.webgameContext;

namespace WebGame
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration
        {
            get;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<TestService>();


            //services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddMvc().AddRazorRuntimeCompilation();

            // For Developing only

            ///////// IDENTITY
            services.AddIdentity<AppUser, AppRole>(options =>
           {
               // options.User.RequireUniqueEmail = true;
           }).AddEntityFrameworkStores<IdentityAppContext>();

            // Identity (takes the database location)
            services.AddDbContext<IdentityAppContext>(cfg =>
           {
               cfg.UseMySql(Configuration.GetConnectionString("WebGame"));
           });
            // Identity
            services.Configure<IdentityOptions>(options =>
           {
               // Password settings
               options.Password.RequireDigit = false;
               options.Password.RequiredLength = 8;
               options.Password.RequireNonAlphanumeric = false;
               options.Password.RequireUppercase = false;
               options.Password.RequireLowercase = false;
               options.Password.RequiredUniqueChars = 0;
           });

            services.AddDbContext<webgameContext>(options =>
               options.UseMySql(Configuration.GetConnectionString("WebGame"))
            );
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddServerSideBlazor();
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
           {
               endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Game}/{action=Tutorial}/{id?}");
               endpoints.MapRazorPages();
               endpoints.MapBlazorHub();
           });
        }
    }
}