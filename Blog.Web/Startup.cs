using Blog.Business;
using Blog.Common;
using Blog.Data;
using Blog.Web.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;

namespace Blog.Web
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
			var cfg = new Configuration();
			Configuration.Bind(cfg);
			var dbUser = Environment.GetEnvironmentVariable("DbUser");
			var dbPass = Environment.GetEnvironmentVariable("DbPass");
			cfg.General.DbConnection = cfg.General.DbConnection.Replace("{dbuser}", dbUser);
			cfg.General.DbConnection = cfg.General.DbConnection.Replace("{dbpass}", dbPass);

			services.Configure<Configuration>(Configuration);
			services.AddScoped(sp => sp.GetService<IOptionsSnapshot<Configuration>>().Value);

			services.AddRazorPages();
			services.AddServerSideBlazor();
			services.AddSingleton<WeatherForecastService>();
			services.AddWebOptimizer(pipeline =>
			{
				//pipeline.AddScssBundle("/bundle.css", "/css/style.scss", "/css/layout.scss", "/css/_colors.scss", "/css/_base.scss");
				pipeline.CompileScssFiles();
			});

			services.AddDataLayer(cfg);
			services.AddBusinessLayer(cfg);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseForwardedHeaders(new ForwardedHeadersOptions
			{
				ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
			});

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseWebOptimizer();
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
