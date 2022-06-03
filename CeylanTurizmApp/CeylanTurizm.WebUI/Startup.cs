using CeylanTurizm.Business.Abstract;
using CeylanTurizm.Business.Concrete;
using CeylanTurizm.Data;
using CeylanTurizm.Data.Abstract;
using CeylanTurizm.Data.Concrete.EfCore;
using CeylanTurizm.WebUI.EmailSender;
using CeylanTurizm.WebUI.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiniShopApp.WebUI.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeylanTurizm.WebUI
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
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer("Server=DESKTOP-GGAL04A;Database=CeylanTurizm;User=sa;Pwd=535598;"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;


                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);


                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
            });


            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                options.Cookie = new CookieBuilder()
                {
                    HttpOnly = true,
                    Name = "CeylanTuriz.Cookie",
                    SameSite = SameSiteMode.Strict
                };
            });
            services.AddScoped<IBusRepository, EfCoreBusRepository>();
            services.AddScoped<IExpeditionRepository, EfCoreExpeditonRepository>();
            services.AddScoped<ITicketSalesRepository, EfCoreTicketSalesRepository>();
            services.AddScoped<ICityRepository, EfCoreCityRepository>();
            services.AddScoped<IEmailSender, SmtpEmailSender>(i => new SmtpEmailSender(
                Configuration["EmailSender:Host"],
                Configuration.GetValue<int>("EmailSender:Port"),
                Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                Configuration["EmailSender:UserName"],
                Configuration["EmailSender:Password"]
                ));
            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<IBusService, BusManager>();
            services.AddScoped<ITicketSalesService, TicketSalesManager>();
            services.AddScoped<IExpeditionService, ExpeditionManager>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                SeedData.Seed();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "uyekayit",
                    pattern: "uye-kayit",
                    defaults: new { controller = "Account", Action = "Register" }
                    );
                endpoints.MapControllerRoute(
                    name: "uyegirisi",
                    pattern: "uye-girisi",
                    defaults: new { controller = "Account", Action = "Login" }
                    );
                endpoints.MapControllerRoute(
                    name: "genelbilgiler",
                    pattern: "genel-bilgiler",
                    defaults: new { controller = "Home", Action = "PublicInformation" }
                    );
                endpoints.MapControllerRoute(
                    name: "kvkkyasalsozlesmeler",
                    pattern: "kvkk-yasal-sozlesmeler",
                    defaults: new { controller = "Home", Action = "KVKK" }
                    );
                endpoints.MapControllerRoute(
                    name: "yolcuhaklari",
                    pattern: "yolcu-haklari",
                    defaults: new { controller = "Home", Action = "PassengerRights" }
                    );
                endpoints.MapControllerRoute(
                    name: "ticket",
                    pattern: "ticket",
                    defaults: new { controller = "TicketSales", Action = "Index" }
                    );
                endpoints.MapControllerRoute(
                   name: "ticketfound",
                   pattern: "ticket/found",
                   defaults: new { controller = "TicketSales", Action = "TicketFound" }
                   );
                endpoints.MapControllerRoute(
                    name: "ticketQuery",
                    pattern: "bilet/sorgu",
                    defaults: new { controller = "TicketSales", Action = "TicketQuery" }
                    );
                endpoints.MapControllerRoute(
                    name: "city",
                    pattern: "city/{name}",
                    defaults: new { controller = "City", Action = "Index" }
                    );
                endpoints.MapControllerRoute(
                    name: "bilet",
                    pattern: "bilet/{city}",
                    defaults: new { controller = "Expedition", Action = "Index" }
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            SeedIdentity.Seed(userManager, roleManager, Configuration).Wait();
        }
    }
}
