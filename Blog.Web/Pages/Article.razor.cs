using Blazorise.RichTextEdit;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Blog.Web.Pages
{
	public partial class Article : ComponentBase
	{
		[Parameter]
		public string Id { get; set; }


        protected RichTextEdit richTextEditRef;
        protected bool readOnly;
        protected string contentAsHtml;
        protected string contentAsDeltaJson;
        protected string contentAsText;
        protected string savedContent;

        public async Task OnContentChanged()
        {
            contentAsHtml = await richTextEditRef.GetHtmlAsync();
            contentAsDeltaJson = await richTextEditRef.GetDeltaAsync();
            contentAsText = await richTextEditRef.GetTextAsync();
        }

        public async Task OnSave()
        {
            savedContent = await richTextEditRef.GetHtmlAsync();
            await richTextEditRef.ClearAsync();
        }

    }

	
}
