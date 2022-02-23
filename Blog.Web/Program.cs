using Blog.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NReco.Logging.File;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Blog.Web
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = CreateHostBuilder(args).Build();

			var file = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "log.txt");
			var factory = new LoggerFactory();
			factory.AddProvider(new FileLoggerProvider(file));
			var logger = factory.CreateLogger("T");

			logger.LogInformation("Testing");
			logger.LogInformation($"args: {string.Join(',', args)}");

			if (OperatingSystem.IsLinux())
			{
				Environment.SetEnvironmentVariable("DbUser", args[0]);
				Environment.SetEnvironmentVariable("DbPass", args[1]);
			}

			var dbUser = Environment.GetEnvironmentVariable("DbUser");
			var dbPass = Environment.GetEnvironmentVariable("DbPass");

			logger.LogInformation(dbUser);
			logger.LogInformation(dbPass);

			using (var scope = host.Services.CreateScope())
			{
				var db = scope.ServiceProvider.GetRequiredService<Context>();
				db.Database.Migrate();
			}

			host.Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
					webBuilder.UseUrls("http://*:5000", "https://*:5001");
				});

		public static class OperatingSystem
		{
			public static bool IsWindows() =>
				RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

			public static bool IsMacOS() =>
				RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

			public static bool IsLinux() =>
				RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
		}
	}
}
