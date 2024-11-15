﻿// <auto-generated />
using System;
using HPlusSport.Security.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HPlusSport.Security.Web.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HPlusSport.Security.Web.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Active Wear - Men"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Active Wear - Women"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mineral Water"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Publications"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Supplements"
                        });
                });

            modelBuilder.Entity("HPlusSport.Security.Web.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("HPlusSport.Security.Web.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(14, 2)
                        .HasColumnType("decimal(14,2)");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "",
                            IsAvailable = true,
                            Name = "Grunge Skater Jeans",
                            Price = 68m,
                            Sku = "AWMGSJ"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "",
                            IsAvailable = true,
                            Name = "Polo Shirt",
                            Price = 35m,
                            Sku = "AWMPS"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "",
                            IsAvailable = true,
                            Name = "Skater Graphic T-Shirt",
                            Price = 33m,
                            Sku = "AWMSGT"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "",
                            IsAvailable = true,
                            Name = "Slicker Jacket",
                            Price = 125m,
                            Sku = "AWMSJ"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "",
                            IsAvailable = true,
                            Name = "Thermal Fleece Jacket",
                            Price = 60m,
                            Sku = "AWMTFJ"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "",
                            IsAvailable = true,
                            Name = "Unisex Thermal Vest",
                            Price = 95m,
                            Sku = "AWMUTV"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "",
                            IsAvailable = true,
                            Name = "V-Neck Pullover",
                            Price = 65m,
                            Sku = "AWMVNP"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Description = "",
                            IsAvailable = true,
                            Name = "V-Neck Sweater",
                            Price = 65m,
                            Sku = "AWMVNS"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "",
                            IsAvailable = true,
                            Name = "V-Neck T-Shirt",
                            Price = 17m,
                            Sku = "AWMVNT"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "",
                            IsAvailable = true,
                            Name = "Bamboo Thermal Ski Coat",
                            Price = 99m,
                            Sku = "AWWBTSC"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Description = "",
                            IsAvailable = false,
                            Name = "Cross-Back Training Tank",
                            Price = 0m,
                            Sku = "AWWCTT"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "",
                            IsAvailable = true,
                            Name = "Grunge Skater Jeans",
                            Price = 68m,
                            Sku = "AWWGSJ"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "",
                            IsAvailable = true,
                            Name = "Slicker Jacket",
                            Price = 125m,
                            Sku = "AWWSJ"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "",
                            IsAvailable = true,
                            Name = "Stretchy Dance Pants",
                            Price = 55m,
                            Sku = "AWWSDP"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "",
                            IsAvailable = true,
                            Name = "Ultra-Soft Tank Top",
                            Price = 22m,
                            Sku = "AWWUTT"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "",
                            IsAvailable = true,
                            Name = "Unisex Thermal Vest",
                            Price = 95m,
                            Sku = "AWWUTV"
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "",
                            IsAvailable = true,
                            Name = "V-Next T-Shirt",
                            Price = 17m,
                            Sku = "AWWVNT"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            Description = "",
                            IsAvailable = true,
                            Name = "Blueberry Mineral Water",
                            Price = 2.8m,
                            Sku = "MWB"
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 3,
                            Description = "",
                            IsAvailable = true,
                            Name = "Lemon-Lime Mineral Water",
                            Price = 2.8m,
                            Sku = "MWLL"
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 3,
                            Description = "",
                            IsAvailable = true,
                            Name = "Orange Mineral Water",
                            Price = 2.8m,
                            Sku = "MWO"
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 3,
                            Description = "",
                            IsAvailable = true,
                            Name = "Peach Mineral Water",
                            Price = 2.8m,
                            Sku = "MWP"
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 3,
                            Description = "",
                            IsAvailable = true,
                            Name = "Raspberry Mineral Water",
                            Price = 2.8m,
                            Sku = "MWR"
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 3,
                            Description = "",
                            IsAvailable = true,
                            Name = "Strawberry Mineral Water",
                            Price = 2.8m,
                            Sku = "MWS"
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 4,
                            Description = "",
                            IsAvailable = true,
                            Name = "In the Kitchen with H+ Sport",
                            Price = 24.99m,
                            Sku = "PITK"
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 5,
                            Description = "",
                            IsAvailable = true,
                            Name = "Calcium 400 IU (150 tablets)",
                            Price = 9.99m,
                            Sku = "SC400"
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 5,
                            Description = "",
                            IsAvailable = true,
                            Name = "Flaxseed Oil 100 mg (90 capsules)",
                            Price = 12.49m,
                            Sku = "SFO100"
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 5,
                            Description = "",
                            IsAvailable = true,
                            Name = "Iron 65 mg (150 caplets)",
                            Price = 13.99m,
                            Sku = "SI65"
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 5,
                            Description = "",
                            IsAvailable = true,
                            Name = "Magnesium 250 mg (100 tablets)",
                            Price = 12.49m,
                            Sku = "SM250"
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 5,
                            Description = "",
                            IsAvailable = true,
                            Name = "Multi-Vitamin (90 capsules)",
                            Price = 9.99m,
                            Sku = "SMV"
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 5,
                            Description = "",
                            IsAvailable = true,
                            Name = "Vitamin A 10,000 IU (125 caplets)",
                            Price = 11.99m,
                            Sku = "SVA"
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 5,
                            Description = "",
                            IsAvailable = true,
                            Name = "Vitamin B-Complex (100 caplets)",
                            Price = 12.99m,
                            Sku = "SVB"
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 5,
                            Description = "",
                            IsAvailable = true,
                            Name = "Vitamin C 1000 mg (100 tablets)",
                            Price = 9.99m,
                            Sku = "SVC"
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 5,
                            Description = "",
                            IsAvailable = true,
                            Name = "Vitamin D3 1000 IU (100 tablets)",
                            Price = 12.49m,
                            Sku = "SVD3"
                        });
                });

            modelBuilder.Entity("HPlusSport.Security.Web.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "adam@example.com",
                            Hash = "NhqTWyInfWPJ1mjJsppbVdrUEbA=",
                            Password = "",
                            Salt = "8Livv5IcUBQZVBNAOqsx7bKN1+xzxIBE8xs3Y8oRWTg="
                        },
                        new
                        {
                            Id = 2,
                            Email = "barbara@example.com",
                            Hash = "6BAqnMBRMbPYP/3+28QhVKcRaAE=",
                            Password = "",
                            Salt = "syRKspY59f8/5NRTupBg7SwNS0j35ZpgEsQEjCu+ZFE="
                        });
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<int>("OrdersId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("OrdersId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrderProduct (Dictionary<string, object>)");
                });

            modelBuilder.Entity("HPlusSport.Security.Web.Models.Order", b =>
                {
                    b.HasOne("HPlusSport.Security.Web.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HPlusSport.Security.Web.Models.Product", b =>
                {
                    b.HasOne("HPlusSport.Security.Web.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("HPlusSport.Security.Web.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HPlusSport.Security.Web.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HPlusSport.Security.Web.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("HPlusSport.Security.Web.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
