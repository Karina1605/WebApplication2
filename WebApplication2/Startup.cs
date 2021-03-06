using BLL.Interfaces;
using BLL.Services;
using DAL;
using DAL.Repositories;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.MiddleWare;

namespace WebApplication2
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
            var connString = Configuration.GetConnectionString("RealEstateContext");
            services.AddDbContext<RealStateContext>(ops => ops.UseSqlServer(connString));
            services.AddScoped<IRepository<Client>, ClientRepository>();
            services.AddScoped<IRepository<BargainType>, BargainTypeRepository>();
            services.AddScoped<IRepository<RealEstate>, RealEstateRepository>();

            services.AddScoped<IRepository<Contract>, ContractRepository>();

            services.AddScoped<IBargainTypeService, BargainTypeService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IRealEstateService, RealService>();
           // services.AddScoped<IBargainTypeService, BLL.HttpServices.BargainTypeService>();
            services.AddScoped<IContractService, BLL.HttpServices.ContractService>();

            

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseMiddleware<ErrorHandler>();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Contract}/{action=Index}/{id?}");
            });
        }
    }
}
