using Microsoft.AspNetCore.Components;

namespace Blog.Web.Components
{
  public partial class ArticleLayout : ComponentBase
  {
		[Parameter]
		public RenderFragment ChildContent { get; set; }
	}
}
