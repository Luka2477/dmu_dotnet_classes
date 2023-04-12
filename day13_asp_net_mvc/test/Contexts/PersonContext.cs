using Microsoft.EntityFrameworkCore;

namespace test.Contexts
{
	public class PersonContext : DbContext
	{
		public PersonContext(DbContextOptions<PersonContext> options) : base(options) { }

		public DbSet<Models.Person> Persons { get; set; }
	}
}

