namespace CleanArchitecture.Persistance.SqlServer {
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext> {
        public ApplicationDbContext CreateDbContext(string[] args) {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseMySql(ServerVersion.Parse("5.0"), 
                n => { 
                    n.MigrationsHistoryTable("MigrationsHistory", Schema.Seven.ToString());
                    n.MigrationsAssembly("CleanArchitecture.Persistance.MySql");
                } );

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
