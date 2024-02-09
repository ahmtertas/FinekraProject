using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebAPI.ContextFactory
{
	public class RepositoryContextFactory :
		IDesignTimeDbContextFactory<FinekraContext>
	{
		public FinekraContext CreateDbContext(string[] args)
		{
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var builder = new DbContextOptionsBuilder<FinekraContext>()
				.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
				project => project.MigrationsAssembly("WebAPI"));

			return new FinekraContext(builder.Options);
		}
	}
}
