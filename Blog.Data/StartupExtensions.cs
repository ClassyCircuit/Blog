using Blog.Business.Interfaces;
using Blog.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Data
{
	public static class StartupExtensions
	{
		public static void AddDataLayer(this IServiceCollection services, Configuration config)
		{
			services.AddDbContextFactory<Context>(options => options.UseSqlServer(config.General.DbConnection,
																b =>
																{
																	b.CommandTimeout(90);
																}));

			services.AddScoped<IArticleRepository, ArticleRepository>();
		}

	}
}