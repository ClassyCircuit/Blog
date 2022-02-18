using Blog.Business.Interfaces;

namespace Blog.Data
{
	public interface IRepository<T> where T : IAggregateRoot
	{
	}
}
