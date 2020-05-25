﻿// <auto-generated />
using System;
using LankhaffInventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LankhaffInventoryManagementSystem.Migrations
{
    [DbContext(typeof(InventoryDBContext))]
    [Migration("20200522122904_AddedStockPriceMigration")]
    partial class AddedStockPriceMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LankhaffInventoryManagementSystem.Models.RegisterCustomer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerAddress")
                        .IsRequired();

                    b.Property<string>("CustomerEmail")
                        .IsRequired();

                    b.Property<string>("CustomerName")
                        .IsRequired();

                    b.Property<string>("CustomerTelephone")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("LankhaffInventoryManagementSystem.Models.RegisterStocks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateStockRegistered");

                    b.Property<string>("StockName")
                        .IsRequired();

                    b.Property<int>("StockPrice");

                    b.HasKey("ID");

                    b.ToTable("Stocks");
                });
#pragma warning restore 612, 618
        }
    }
}
