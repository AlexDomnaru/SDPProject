using System;
using Business;
using Data.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using AutoMapper;
using Business.Interfaces;
using Business.Repositories;
using Data.Domain.Entities;
using Presentation.Items;

namespace Presentation
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
			//transient db stuff goes here
	        services.AddTransient<IAboutYouRepository<AboutYou>, AboutYouRepository>();
	        services.AddTransient<IRiderDetailsRepository<RiderDetails>, RiderDetailsRepository>();
	        services.AddTransient<IFormDbContext, FormDbContext>();
	        services.AddDbContext<ContentDbContext>(options => options.UseInMemoryDatabase("Content"));
	        services.AddDbContext<FormDbContext>(options =>
				options.UseInMemoryDatabase("Forms"));

	        services.AddTransient<DbSeeder>();

	        services.AddAutoMapper();

	        services.AddMvc().AddSessionStateTempDataProvider();

	        services.AddDistributedMemoryCache();
	        services.AddSession(options =>
	        {
		        options.IdleTimeout = TimeSpan.FromSeconds(1500);
		        options.Cookie.Name = "Quote";
		        options.Cookie.HttpOnly = true;
	        });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
	        

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

			app.UseStaticFiles();

	        app.UseSession();

			app.UseMvc(routes =>
			{
				routes.MapRoute("default", "{controller=Quote}/{action=PersonalInformation2}");
			});
		}
    }
}
