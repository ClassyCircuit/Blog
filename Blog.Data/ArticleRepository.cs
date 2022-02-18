using Blog.Business.Interfaces;
using Blog.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
	public class ArticleRepository : IArticleRepository
	{
		private readonly IDbContextFactory<Context> _dbFactory;

		public ArticleRepository(IDbContextFactory<Context> dbFactory)
		{
			_dbFactory = dbFactory;
		}

		public async Task Add(Article article)
		{
			using (var context = _dbFactory.CreateDbContext())
			{
				context.Articles.Add(article);
				await context.SaveChangesAsync();
			}
		}
	}
}
