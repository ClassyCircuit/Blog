using Blog.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
	public class Context : DbContext
	{
		public Context(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Article> Articles { get; set; }
		public DbSet<ArticleText> ArticleText { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Article>()
				.HasOne(t => t.Text)
				.WithOne(t => t.Article)
				.HasForeignKey<ArticleText>(t => t.ArticleId);
		}

		public override int SaveChanges()
		{
			UpdateEntityDates();

			return base.SaveChanges();
		}

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			UpdateEntityDates();

			return base.SaveChangesAsync(cancellationToken);
		}

		private void UpdateEntityDates()
		{
			foreach (var entry in ChangeTracker.Entries())
			{
				if (entry.Entity is not BaseModel model)
				{
					continue;
				}

				switch (entry.State)
				{
					case EntityState.Added:
						model.CreatedAt = DateTime.UtcNow;
						break;
					case EntityState.Modified:
						model.UpdatedAt = DateTime.UtcNow;
						break;
				}
			}
		}
	}
}
