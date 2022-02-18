namespace Blog.Business.Models
{
	public class Category : BaseModel
	{
		public string Name { get; set; }
		public IList<Article> Articles { get; set; }
	}
}