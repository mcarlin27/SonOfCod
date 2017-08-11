using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SonOfCod.Models;

namespace SonOfCod.Migrations
{
    [DbContext(typeof(SonOfCodDbContext))]
    partial class SonOfCodDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SonOfCod.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AverageSize");

                    b.Property<string>("CookingSuggestion");

                    b.Property<int>("Cost");

                    b.Property<string>("Defects");

                    b.Property<string>("FishingMethod");

                    b.Property<string>("MarketName");

                    b.Property<int>("MaxSize");

                    b.Property<string>("Name");

                    b.Property<string>("PrimarySource");

                    b.Property<string>("ProductFormFresh");

                    b.Property<string>("ProductFormFrozen");

                    b.Property<string>("ScientificName");

                    b.Property<string>("Season");

                    b.Property<string>("SellingPoints");

                    b.Property<string>("StorageHandling");

                    b.Property<string>("Summary");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SonOfCod.Models.Recipient", b =>
                {
                    b.Property<int>("RecipientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("RecipientId");

                    b.ToTable("Recipients");
                });
        }
    }
}
