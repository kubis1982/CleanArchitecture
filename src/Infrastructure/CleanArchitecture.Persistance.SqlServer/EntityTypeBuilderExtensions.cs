namespace CleanArchitecture.Persistance.SqlServer {
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class EntityTypeBuilderExtensions {
        public static EntityTypeBuilder<TEntity> ToTable<TEntity>(this EntityTypeBuilder<TEntity> entityTypeBuilder, Schema schema, string name) where TEntity : class {
            return entityTypeBuilder.ToTable(name, schema.ToString());
        }

    }
}
