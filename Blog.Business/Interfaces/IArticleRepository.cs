using Blog.Business.Models;

namespace Blog.Business.Interfaces
{
	public interface IArticleRepository : IRepository<Article>
	{
		Task<int> Add(Article article);
		Task UpdateContent(int articleId, string content);
		Task<int[]> GetRecentArticleIds(int maxLimit);
		Task<string> GetContent(int articleId);
	}
}
