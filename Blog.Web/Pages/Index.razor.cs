using Blog.Business.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Blog.Web.Pages
{
	public partial class Index : ComponentBase
	{
		[Inject]
		private NavigationManager _navigationManager { get; set; }

		[Inject]
		private ArticleService _articleService { get; set; }

		protected void GoToArticle(int id)
		{
			_navigationManager.NavigateTo($"article/{id}");
		}

		protected async Task AddArticle()
		{
			await _articleService.Add();
		}
	}
}
