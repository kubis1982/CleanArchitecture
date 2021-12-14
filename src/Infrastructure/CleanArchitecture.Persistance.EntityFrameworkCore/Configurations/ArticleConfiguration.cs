namespace CleanArchitecture.Persistance.EntityFrameworkCore.Configurations {
    using CleanArchitecture.Domain.Entities;
    using CleanArchitecture.Domain.ValueObjects;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;

    internal class ArticleConfiguration : IEntityTypeConfiguration<Article> {
        public void Configure(EntityTypeBuilder<Article> builder) {
            builder.HasKey(e => e.Id);

            builder.Property(n => n.Code)
                .HasConversion(
                    n => n.Text,
                    n => new ArticleCode(n))
                .HasMaxLength(40)
                .IsRequired();

            builder.HasIndex(p => p.Code).IsUnique();

            builder.Property(n => n.Name)
                .HasMaxLength(255);

            builder.Property(n => n.Unit)
                 .HasConversion(
                    n => n.Name,
                    n => new UnitName(n))
                .HasMaxLength(10);

            builder.OwnsMany(n => n.AlternativeUnits, n => {
                n.Property(n => n.Unit)
                  .HasConversion(
                    n => n.Name,
                    n => new UnitName(n))
                  .HasMaxLength(10);

                n.HasKey(nameof(Article) + nameof(Article.Id), nameof(ArticleUnit.Unit));
            });
        }
    }
}
