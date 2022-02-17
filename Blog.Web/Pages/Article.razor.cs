using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Blog.Web.Pages
{
	public partial class Article : ComponentBase
	{
		[Parameter]
		public string Id { get; set; }
		protected string Content { get; set; }
    }
}
