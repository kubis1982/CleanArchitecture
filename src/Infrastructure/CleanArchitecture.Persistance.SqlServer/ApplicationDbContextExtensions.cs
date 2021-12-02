namespace CleanArchitecture.Persistance.SqlServer {
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal static class ApplicationDbContextExtensions {
        public static EntityTypeBuilder<TEntity> ToTable<TEntity>(this EntityTypeBuilder<TEntity> entityTypeBuilder, Schema schema, string name) where TEntity : class {
            return entityTypeBuilder.ToTable(name, schema.ToString());
        }

        public static OwnedNavigationBuilder<TOwnerEntity, TRelatedEntity> ToTable<TOwnerEntity, TRelatedEntity>(this OwnedNavigationBuilder<TOwnerEntity, TRelatedEntity> referenceOwnershipBuilder, Schema schema, string name) where TOwnerEntity : class where TRelatedEntity : class {
            return referenceOwnershipBuilder.ToTable(name, schema.ToString());
        }


    }
}
