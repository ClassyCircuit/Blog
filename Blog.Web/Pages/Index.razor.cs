using Microsoft.AspNetCore.Components;

namespace Blog.Web.Pages
{
  public partial class Index : ComponentBase
  {
    [Inject]
    private NavigationManager _navigationManager { get; set; }

    protected void GoToArticle(int id)
    {
        _navigationManager.NavigateTo($"article/{id}");
    }
  }
}
