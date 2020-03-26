﻿// <auto-generated />
using System;
using GiftShopDatabaseImplement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GiftShopDatabaseImplement.Migrations
{
    [DbContext(typeof(GiftShopDatabase))]
    [Migration("20200325202325_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GiftShopDatabaseImplement.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ComponentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("GiftShopDatabaseImplement.Models.GiftSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GiftSetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("GiftSets");
                });

            modelBuilder.Entity("GiftShopDatabaseImplement.Models.GiftSetComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComponentId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("GiftSetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId");

                    b.HasIndex("GiftSetId");

                    b.ToTable("GiftSetComponents");
                });

            modelBuilder.Entity("GiftShopDatabaseImplement.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateImplement")
                        .HasColumnType("datetime2");

                    b.Property<int>("GiftSetId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("GiftSetId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GiftShopDatabaseImplement.Models.GiftSetComponent", b =>
                {
                    b.HasOne("GiftShopDatabaseImplement.Models.Component", "Component")
                        .WithMany("GiftSetComponents")
                        .HasForeignKey("ComponentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GiftShopDatabaseImplement.Models.GiftSet", "GiftSet")
                        .WithMany("GiftSetComponents")
                        .HasForeignKey("GiftSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GiftShopDatabaseImplement.Models.Order", b =>
                {
                    b.HasOne("GiftShopDatabaseImplement.Models.GiftSet", "GiftSet")
                        .WithMany("Orders")
                        .HasForeignKey("GiftSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
