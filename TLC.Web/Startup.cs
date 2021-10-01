using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TLC.Data.Repositories;
using TLC.Data.Services;
using TLC.Data.Services.Interfaces;
using TLC.Web.Data;
using Microsoft.EntityFrameworkCore;
using TLC.Blazor.Services.Interfaces;
using TLC.Blazor.Services;
using EmbeddedBlazorContent;

namespace TLC.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            //var cs = Configuration.GetConnectionString("Default");
            //inject db context to keep as short lived as possible
            //services.AddDbContextFactory<DatabaseContext>(opt => opt.UseSqlServer(cs));
            //services.AddDbContext<DatabaseContext>(opt => opt.UseSqlServer(cs));

            /*services.AddDbContextFactory<DatabaseContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));*/

            // Data Services

            services.AddScoped<IProductServiceDb, ProductServiceDb>();
            services.AddScoped<IOrderServiceDb, OrderServiceDb>();
            services.AddScoped<IUserServiceDb, UserServiceDb>();
            services.AddScoped<IBasketServiceDb, BasketServiceDb>();

            // Blazor Services
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IUserService, UserService>();

            //services.AddAuthorizationCore();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // ensure app is seeded with data
                Seeder.Seed(new UserServiceDb(), new ProductServiceDb(), new BasketServiceDb(), new OrderServiceDb());
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
