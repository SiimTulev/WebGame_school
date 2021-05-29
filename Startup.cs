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

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<OverallStatsLogic>(); //AddSingleton ei tööta, aga AddTransient ja AddScoped töötavad
            services.AddScoped<MainGameLogic>(); //AddSingleton ei tööta, aga AddTransient ja AddScoped töötavad

            services.AddRazorPages().AddRazorRuntimeCompilation(); // PÄRAST MAHA V6TTA?
            services.AddMvc().AddRazorRuntimeCompilation();


            ///////// IDENTITY
            services.AddIdentity<AppUser, AppRole>(options =>
           {
           }).AddEntityFrameworkStores<IdentityAppContext>();

            // Identity (võtab andmebaasi andmete asukoha)
            services.AddDbContext<IdentityAppContext>(cfg =>
               cfg.UseMySql(Configuration.GetConnectionString("WebGame")),
            ServiceLifetime.Transient);

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
               options.UseMySql(Configuration.GetConnectionString("WebGame")),
            ServiceLifetime.Transient);

            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddServerSideBlazor();
        }

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
               pattern: "{controller=Game}/{action=Tutorial}");
               endpoints.MapRazorPages();
               endpoints.MapBlazorHub();
               endpoints.MapHub<NotificationHub>("/notificationHub"); // VAJALIK

           });
        }
    }
}