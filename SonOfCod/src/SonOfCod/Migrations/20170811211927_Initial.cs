using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SonOfCod.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AverageSize = table.Column<int>(nullable: false),
                    CookingSuggestion = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    Defects = table.Column<string>(nullable: true),
                    FishingMethod = table.Column<string>(nullable: true),
                    MarketName = table.Column<string>(nullable: true),
                    MaxSize = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PrimarySource = table.Column<string>(nullable: true),
                    ProductFormFresh = table.Column<string>(nullable: true),
                    ProductFormFrozen = table.Column<string>(nullable: true),
                    ScientificName = table.Column<string>(nullable: true),
                    Season = table.Column<string>(nullable: true),
                    SellingPoints = table.Column<string>(nullable: true),
                    StorageHandling = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Recipients",
                columns: table => new
                {
                    RecipientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipients", x => x.RecipientId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Recipients");
        }
    }
}
