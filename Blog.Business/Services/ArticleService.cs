using Blog.Business.Interfaces;
using Blog.Business.Models;

namespace Blog.Business.Services
{
	public class ArticleService
	{
		private readonly IArticleRepository _articleRepository;

		public ArticleService(IArticleRepository articleRepository)
		{
			_articleRepository = articleRepository;
		}

		public async Task Add()
		{
			var article = new Article()
			{
				Title = "Work In Progress"
			};

			await _articleRepository.Add(article);
		}
	}
}
