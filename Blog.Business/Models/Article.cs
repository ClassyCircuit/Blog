using Blog.Business.Interfaces;

namespace Blog.Business.Models
{
	public class Article : BaseModel, IAggregateRoot
	{
		public User Author { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public ArticleText Text { get; set; }
		public bool IsPublished { get; set; }
		public Category Category { get; set; }
		public IList<Tag> Tags { get; set; }
		public IList<Comment> Comments { get; set; }
	}
}
