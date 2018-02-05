using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Items;

namespace Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
	        using (var scope = BuildWebHost(args).Services.CreateScope())
	        {
		        var services = scope.ServiceProvider;
		        try
		        {
			        var seeder = services.GetRequiredService<DbSeeder>();
			        seeder.SeedAsync().Wait();
		        }
		        catch (AggregateException e)
		        {
			        throw new Exception(e.ToString());
		        }
			}
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
