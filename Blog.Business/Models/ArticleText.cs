namespace Blog.Business.Models
{
	public class ArticleText : BaseModel
	{
		public string Content { get; set; }

		public int ArticleId { get; set; }
		public Article Article { get; set; }
	}
}