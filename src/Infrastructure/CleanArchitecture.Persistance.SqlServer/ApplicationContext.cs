namespace CleanArchitecture.Persistance.SqlServer {
    using CleanArchitecture.Domain.Entities;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationContext : DbContext {
        public ApplicationContext(DbContextOptions dbContextOptions) : base(dbContextOptions) {
        }

        public DbSet<Article> Articles { get; set; }

        public DbSet<ArticleUnit> ArticleUnits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
