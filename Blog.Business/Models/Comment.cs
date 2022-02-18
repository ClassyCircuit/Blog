namespace Blog.Business.Models
{
	public class Comment : BaseModel
	{
		public Article Article { get; set; }
		public string Text { get; set; }
		public User Author { get; set; }
	}
}