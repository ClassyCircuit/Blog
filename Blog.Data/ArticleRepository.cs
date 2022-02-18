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

		public async Task<int> Add(Article article)
		{
			using (var context = _dbFactory.CreateDbContext())
			{
				context.Articles.Add(article);
				await context.SaveChangesAsync();
				return article.Id;
			}
		}

		public async Task<string> GetContent(int articleId)
		{
			using (var context = _dbFactory.CreateDbContext())
			{
				var article = await context.Articles.Include(t => t.Text).FirstAsync(t => t.Id == articleId);
				return article.Text.Content;
			}
		}
		public async Task<int[]> GetRecentArticleIds(int maxLimit)
		{
			using (var context = _dbFactory.CreateDbContext())
			{
				return await context.Articles.OrderByDescending(t => t.CreatedAt).Take(maxLimit).Select(t => t.Id).ToArrayAsync();
			}
		}

		public async Task UpdateContent(int articleId, string content)
		{
			using (var context = _dbFactory.CreateDbContext())
			{
				var article = await context.Articles.Include(t => t.Text).FirstOrDefaultAsync(t => t.Id == articleId);
				if (article.Text == null)
				{
					article.Text = new ArticleText(content);
				}
				else
				{
					article.Text.Content = content;
				}

				await context.SaveChangesAsync();
			}
		}
	}
}
