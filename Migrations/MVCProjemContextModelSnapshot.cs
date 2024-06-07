﻿// <auto-generated />
using MVCProjem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCProjem.Migrations
{
    [DbContext(typeof(MVCProjemContext))]
    partial class MVCProjemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVCProjem.Models.Kitap", b =>
                {
                    b.Property<int>("kitapno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("kitapno"), 1L, 1);

                    b.Property<string>("VerilisTarihi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ogrno")
                        .HasColumnType("int");

                    b.Property<string>("turno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("verildimi")
                        .HasColumnType("bit");

                    b.Property<int>("yazarno")
                        .HasColumnType("int");

                    b.HasKey("kitapno");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("MVCProjem.Models.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("MVCProjem.Models.Yazar", b =>
                {
                    b.Property<int>("yazarno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("yazarno"), 1L, 1);

                    b.Property<string>("ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("yazarno");

                    b.ToTable("Yazarlar");
                });
#pragma warning restore 612, 618
        }
    }
}
