﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchitecture.Persistance.SqlLite.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Seven");

            migrationBuilder.CreateTable(
                name: "Article",
                schema: "Seven",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Unit = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleUnit",
                schema: "Seven",
                columns: table => new
                {
                    Unit = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    ArticleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleUnit", x => new { x.ArticleId, x.Unit });
                    table.ForeignKey(
                        name: "FK_ArticleUnit_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalSchema: "Seven",
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_Code",
                schema: "Seven",
                table: "Article",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleUnit",
                schema: "Seven");

            migrationBuilder.DropTable(
                name: "Article",
                schema: "Seven");
        }
    }
}
