namespace CleanArchitecture.Persistance.EntityFrameworkCore.SqlServer {
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext> {
        public ApplicationDbContext CreateDbContext(string[] args) {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=CleanArchitectureDb;Integrated Security=True", 
                n => { 
                    n.MigrationsHistoryTable("MigrationsHistory", Schema.Seven.ToString());
                    n.MigrationsAssembly(GetType().Assembly.FullName);
                } );

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
