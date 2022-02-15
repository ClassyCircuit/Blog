using Microsoft.AspNetCore.Components;

namespace Blog.Web.Components
{
  public partial class Card : ComponentBase
  {
	    [Parameter]
	    public int Id { get; set; }

        [Inject]
        private NavigationManager _navigationManager { get; set; }

        protected void GoToArticle(int id)
        {
            _navigationManager.NavigateTo($"article/{id}");
        }
    }
}
