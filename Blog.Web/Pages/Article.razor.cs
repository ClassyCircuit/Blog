using Microsoft.AspNetCore.Components;

namespace Blog.Web.Pages
{
	public partial class Article : ComponentBase
	{
		[Parameter]
		public string Id { get; set; }

		public TextModel Model { get; set; }

		protected void HandleValidSubmit()
		{

			// Process the valid form
		}


	}

	public class TextModel
	{
		public string Id { get; set; }
		public string Text { get; set; }


	}
}
