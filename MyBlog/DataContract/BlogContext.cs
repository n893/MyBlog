using System.Data.Entity;

namespace MyBlog.DataContract
{
	public class BlogContext : DbContext
	{
		public DbSet<Post> Posts { get; set; }
	}
}