namespace CleanArchitecture.Persistance.SqlServer {
    using CleanArchitecture.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;

    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) {
        }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema(Schema.Seven.ToString());

            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes()) {
                entity.SetTableName(entity.DisplayName());
            }

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
