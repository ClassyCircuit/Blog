namespace Blog.Business.Interfaces
{
	public interface IRepository<T> where T : IAggregateRoot
	{
	}
}
