﻿// <auto-generated />
using GallerySiteProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GallerySiteProject.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240530021421_migration1")]
    partial class migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GallerySiteProject.Models.TblGiris", b =>
                {
                    b.Property<int>("GirisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GirisAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GirisAdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GirisFacebookURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GirisInstagramURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GirisLinkedinURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GirisMailURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GirisID");

                    b.ToTable("tblGirises");
                });

            modelBuilder.Entity("GallerySiteProject.Models.TblHakkimda", b =>
                {
                    b.Property<int>("HakkimdaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("HakkimdaBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkimdaGiris")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HakkimdaText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HakkimdaID");

                    b.ToTable("tblHakkimdas");
                });

            modelBuilder.Entity("GallerySiteProject.Models.TblResimler", b =>
                {
                    b.Property<int>("ResimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ResimURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResimlerTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResimID");

                    b.ToTable("tblResimlers");
                });
#pragma warning restore 612, 618
        }
    }
}
