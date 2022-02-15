using Microsoft.AspNetCore.Components;

namespace Blog.Web.Pages
{
	public partial class Article : ComponentBase
	{
		[Parameter]
		public string Id { get; set; }


	}
}
