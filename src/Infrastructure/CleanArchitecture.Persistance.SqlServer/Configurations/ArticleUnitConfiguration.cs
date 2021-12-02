namespace CleanArchitecture.Persistance.SqlServer.Configurations {
    using CleanArchitecture.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;

    internal class ArticleUnitConfiguration : IEntityTypeConfiguration<ArticleUnit> {
        public void Configure(EntityTypeBuilder<ArticleUnit> builder) {
            builder.ToTable(Schema.Seven, "ArticleUnit");
            
            builder.Property(n => n.Unit)
                .HasMaxLength(10);

            builder.OwnsOne(n => n.Created, n => {
                n.Property(m => m.UserId).HasColumnName("CreatedBy");
                n.Property(m => m.DateTime).HasColumnName("CreatedOn");
            });

            builder.OwnsOne(n => n.Modified, n => {
                n.Property(m => m.UserId).HasColumnName("ModifiedBy");
                n.Property(m => m.DateTime).HasColumnName("ModifiedOn");
            });

            builder.HasOne(d => d.Article)
                .WithMany(p => p.Units)
                .HasForeignKey(d => d.Article.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Article_Article_Units");
        }
    }
}
