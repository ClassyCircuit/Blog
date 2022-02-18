namespace Blog.Business.Models
{
	public class Tag : BaseModel
	{
		public string Name { get; set; }
		public IList<Article> Articles { get; set; }
	}
}