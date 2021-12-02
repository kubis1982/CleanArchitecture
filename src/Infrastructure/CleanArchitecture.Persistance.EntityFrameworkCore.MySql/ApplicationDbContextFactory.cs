namespace CleanArchitecture.Persistance.EntityFrameworkCore.SqlServer {
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext> {
        public ApplicationDbContext CreateDbContext(string[] args) {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseMySql(ServerVersion.Parse("8.0.27"), 
                n => { 
                    n.MigrationsHistoryTable("MigrationsHistory", Schema.Seven.ToString());
                    n.MigrationsAssembly(GetType().Assembly.FullName);
                } );

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
