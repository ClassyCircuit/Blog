using Blog.Business.Models;

namespace Blog.Business.Interfaces
{
	public interface IArticleRepository : IRepository<Article>
	{
		Task Add(Article article);
	}
}
