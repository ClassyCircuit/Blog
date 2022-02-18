namespace Blog.Business.Models
{
	public class User : BaseModel
	{
		public IList<Article> Articles { get; set; }
		public IList<Comment> Comments { get; set; }
	}
}