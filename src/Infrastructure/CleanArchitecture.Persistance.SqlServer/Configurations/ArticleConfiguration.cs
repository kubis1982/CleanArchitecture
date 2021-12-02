namespace CleanArchitecture.Persistance.SqlServer.Configurations {
    using CleanArchitecture.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;

    internal class ArticleConfiguration : IEntityTypeConfiguration<Article> {
        public void Configure(EntityTypeBuilder<Article> builder) {
            builder.ToTable(Schema.Seven, "Article");

            builder.HasKey(e => e.Id);

            builder.Property(n => n.Code)
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(n => n.Name)
                .HasMaxLength(255);

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
        }
    }
}
