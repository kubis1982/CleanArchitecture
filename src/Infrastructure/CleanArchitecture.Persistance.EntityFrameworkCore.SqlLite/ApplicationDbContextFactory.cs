namespace CleanArchitecture.Persistance.SqlLite {
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext> {
        public ApplicationDbContext CreateDbContext(string[] args) {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source=CleanArchitectureDb.sqlite", 
                n => {
                    n.MigrationsHistoryTable("MigrationsHistory", Schema.Seven.ToString());
                    n.MigrationsAssembly(GetType().Assembly.FullName);
                });

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
