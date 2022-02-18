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

		public async Task<int> AddDraft()
		{
			var article = new Article()
			{
				Title = "Work In Progress",
				Description = "WIP",
				IsPublished = false,
				Text = new ArticleText("Start writing..")
			};

			return await _articleRepository.Add(article);
		}

		public async Task<int[]> GetRecentArticles(int maxLimit)
		{
			return await _articleRepository.GetRecentArticleIds(maxLimit);
		}

		public async Task SaveContent(int articleId, string content)
		{
			await _articleRepository.UpdateContent(articleId: articleId, content: content);
		}

		public async Task<string> GetContent(int articleId)
		{
			return await _articleRepository.GetContent(articleId: articleId);
		}
	}
}
