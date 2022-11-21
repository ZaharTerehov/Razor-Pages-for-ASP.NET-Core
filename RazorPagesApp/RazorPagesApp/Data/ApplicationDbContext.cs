using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Model;

namespace RazorPagesApp.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Category> Category { get; set; }
	}
}
