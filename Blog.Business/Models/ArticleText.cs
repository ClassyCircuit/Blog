namespace Blog.Business.Models
{
	public class ArticleText : BaseModel
	{
		public string Content { get; set; }

		public ArticleText(string content)
		{
			Content = content;
		}
	}
}