using Business;
using Data.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using FluentValidation.AspNetCore;
using AutoMapper;
using Business.Interfaces;
using Business.Repositories;
using Data.Domain.Entities;

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
	        services.AddDbContext<FormDbContext>(options =>
				options.UseInMemoryDatabase("Forms"));

	        services.AddMvc().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Startup>());

	        services.AddAutoMapper();

	        services.AddSwaggerGen(c =>
		        c.SwaggerDoc("v1", new Info { Title = "Swagger page to test api", Version = "v1" }));

			services.AddMvc();
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

	        app.UseSwagger();
	        app.UseSwaggerUI(c =>
	        {
		        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test area");
	        });

			app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
