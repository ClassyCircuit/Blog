using Microsoft.AspNetCore.Components;

namespace Blog.Web.Components
{
  public partial class CardLayout : ComponentBase
  {
		[Parameter]
		public RenderFragment ChildContent { get; set; }
	}
}
