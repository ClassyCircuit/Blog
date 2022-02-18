using Blog.Business.Services;
using Blog.Common;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Business
{
	public static class StartupExtensions
	{
		public static void AddBusinessLayer(this IServiceCollection services, Configuration config)
		{
			services.AddScoped<ArticleService>();
		}
	}
}
