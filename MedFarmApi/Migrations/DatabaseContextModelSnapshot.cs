﻿// <auto-generated />
using System;
using MedFarmApi.Features.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedFarmApi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MedFarmApi.Features.Category.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MedFarmApi.Features.Cattle.Cattles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Behaviour")
                        .HasColumnType("longtext");

                    b.Property<string>("Color")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("DeliveryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("EarLength")
                        .HasColumnType("double");

                    b.Property<string>("EyeColor")
                        .HasColumnType("longtext");

                    b.Property<string>("FatherSideHistory")
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HabitOfEating")
                        .HasColumnType("longtext");

                    b.Property<double?>("Height")
                        .HasColumnType("double");

                    b.Property<double?>("HornLength")
                        .HasColumnType("double");

                    b.Property<int>("IdNumber")
                        .HasColumnType("int");

                    b.Property<double?>("Length")
                        .HasColumnType("double");

                    b.Property<double?>("MilkCapacityInLiters")
                        .HasColumnType("double");

                    b.Property<string>("MotherSideHistory")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nature")
                        .HasColumnType("longtext");

                    b.Property<double?>("TailLength")
                        .HasColumnType("double");

                    b.Property<int?>("Teeth")
                        .HasColumnType("int");

                    b.Property<string>("UdderColor")
                        .HasColumnType("longtext");

                    b.Property<double?>("Weight")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Cattles");
                });

            modelBuilder.Entity("MedFarmApi.Features.Product.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageName")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MedFarmApi.Features.Product.Products", b =>
                {
                    b.HasOne("MedFarmApi.Features.Category.Categories", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
