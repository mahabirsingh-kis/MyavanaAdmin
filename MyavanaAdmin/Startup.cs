using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Http.Features;
//using Microsoft.Extensions.Hosting;

namespace MyavanaAdmin
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
            //services.AddControllersWithViews();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //services.AddScoped<MyavanaAdminApiClient.ApiClient>(_ => new MyavanaAdminApiClient.ApiClient(new Uri("https://api.myavana.com/")));
            services.AddScoped<MyavanaAdminApiClient.ApiClient>(_ => new MyavanaAdminApiClient.ApiClient(new Uri("http://localhost:5004/api/")));
            //services.Configure<RazorPagesOptions>(options => options.RootDirectory = "/Views");
            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = int.MaxValue;
                x.MultipartHeadersLengthLimit = int.MaxValue;
            });
            services.AddMvc()
        .AddSessionStateTempDataProvider();
            services.AddSession();


            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.Cookie.SecurePolicy = CookieSecurePolicy.None;
                options.Cookie.SameSite = SameSiteMode.Lax;
                options.LoginPath = "/Auth/Login";
                options.Cookie.Name = "AuthCookies";
                options.Cookie.Expiration = DateTime.Now.AddDays(-1).TimeOfDay;
            })
        .AddCookie("AdminCookies", o =>
        {
            o.ExpireTimeSpan = DateTime.Now.AddDays(-1).TimeOfDay;
            o.LoginPath = new PathString("/Auth/Login");
            o.Cookie.Name = "AdminCookies";
            o.SlidingExpiration = true;
        });
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.MinimumSameSitePolicy = SameSiteMode.Strict;
                options.HttpOnly = HttpOnlyPolicy.None;
                options.Secure = CookieSecurePolicy.None;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Privacy");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Views",
                    template: "{controller=Auth}/{action=Login}/{id?}");
            });

        }
    }
}
