﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SiberianSales2.Data;
using SiberianSales2.Services;

namespace SiberianSales2
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<SiberianSales2Context>(options =>
                    options.UseMySql(Configuration.GetConnectionString("SiberianSales2Context"), builder => builder.MigrationsAssembly("SiberianSales2")));

            services.AddScoped<SeedingService>();
            services.AddScoped<SalesProposalService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SeedingService seedingService)
        {
            var ptBR = new CultureInfo("pt-BR");
            ptBR.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ptBR.DateTimeFormat.ShortTimePattern = "HH:mm";
            ptBR.NumberFormat.NumberDecimalDigits = 2;
            ptBR.NumberFormat.NumberDecimalSeparator = ",";
            ptBR.NumberFormat.CurrencyDecimalDigits = 2;
            ptBR.NumberFormat.CurrencyDecimalSeparator = ",";

            var enUS = new CultureInfo("en-US");

            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ptBR),
                SupportedCultures = new List<CultureInfo> { ptBR, enUS },
                SupportedUICultures = new List<CultureInfo> { ptBR, enUS }
            };

            app.UseRequestLocalization(localizationOptions);
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                seedingService.Seed();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
