namespace Blog.Business.Models
{
	public class ArticleText : BaseModel
	{
		public Article Article { get; set; }
		public string Content { get; set; }
	}
}