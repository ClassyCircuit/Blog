using Microsoft.AspNetCore.Components;

namespace Blog.Web.Components
{
  public partial class Card : ComponentBase
  {
	[Parameter]
	public int Id { get; set; }

  }
}
