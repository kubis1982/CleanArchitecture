﻿// <auto-generated />
using CleanArchitecture.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CleanArchitecture.Persistance.EntityFrameworkCore.SqlLite.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Seven")
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("CleanArchitecture.Domain.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Article");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Entities.Article", b =>
                {
                    b.OwnsMany("CleanArchitecture.Domain.ValueObjects.ArticleUnit", "AlternativeUnits", b1 =>
                        {
                            b1.Property<int>("ArticleId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Unit")
                                .HasMaxLength(10)
                                .HasColumnType("TEXT");

                            b1.HasKey("ArticleId", "Unit");

                            b1.ToTable("ArticleUnit");

                            b1.WithOwner()
                                .HasForeignKey("ArticleId");
                        });

                    b.Navigation("AlternativeUnits");
                });
#pragma warning restore 612, 618
        }
    }
}