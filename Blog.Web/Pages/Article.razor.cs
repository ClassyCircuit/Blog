using Blog.Business.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Web.Pages
{
	public partial class Article : ComponentBase
	{
		[Parameter]
		public string Id { get; set; }

		private int _articleId;
		protected string Content { get; set; }
		protected Dictionary<string, object> EditorConfig = new Dictionary<string, object>
	{
	{"plugins", "autoresize print preview paste importcss searchreplace autolink autosave save directionality code visualblocks visualchars fullscreen image link media template codesample table charmap hr pagebreak nonbreaking anchor toc insertdatetime advlist lists wordcount imagetools textpattern noneditable help charmap quickbars emoticons"},
	{"imagetools_cors_hosts", "picsum.photos"},
	{"menubar", "file edit view insert format tools table help"},

	{"toolbar", "undo redo | bold italic underline strikethrough | fontselect fontsizeselect formatselect | alignleft aligncenter alignright alignjustify | outdent indent |  numlist bullist | forecolor backcolor removeformat | pagebreak | charmap emoticons | fullscreen  preview save print | insertfile image media template link anchor codesample | ltr rtl" },
	{"toolbar_sticky", true},
	{"paste_data_images", true},
	{"image_advtab", true},
	{"image_caption", true},
	{"quickbars_selection_toolbar", "bold italic | quicklink h2 h3 blockquote quickimage quicktable"},
	{"noneditable_noneditable_class", "mceNonEditable"},
	{"toolbar_mode", "sliding"},
	{"contextmenu", "link image imagetools table"},
	{"skin", "oxide"},
	{"content_css", "default"},
	{"content_style", "body { font-family:Helvetica,Arial,sans-serif; font-size:14px"}
	};

		[Inject]
		private ArticleService _articleService { get; set; }

		protected override async Task OnInitializedAsync()
		{
			_articleId = int.Parse(Id);
			Content = await _articleService.GetContent(articleId: _articleId);
		}

		protected async Task Save()
		{
			await _articleService.SaveContent(articleId: _articleId, content: Content);
		}

		protected void Discard()
		{
			// delete WIP article
			// navigate to index
		}
	}
}
