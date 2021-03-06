﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApi5.Data;

namespace WebApi5.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20201126120226_Orkhan")]
    partial class Orkhan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebApi5.Data.Models.CategoryW", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("categoryType")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CategoryW");
                });

            modelBuilder.Entity("WebApi5.Data.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("CategoryWId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("data")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("fileName")
                        .HasColumnType("text");

                    b.Property<int>("idVersion")
                        .HasColumnType("integer");

                    b.Property<int>("materialId")
                        .HasColumnType("integer");

                    b.Property<string>("materialName")
                        .HasColumnType("text");

                    b.Property<string>("pathOfFile")
                        .HasColumnType("text");

                    b.Property<int>("size")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryWId");

                    b.ToTable("File");
                });

            modelBuilder.Entity("WebApi5.Data.Models.File", b =>
                {
                    b.HasOne("WebApi5.Data.Models.CategoryW", "CategoryW")
                        .WithMany("File")
                        .HasForeignKey("CategoryWId");

                    b.Navigation("CategoryW");
                });

            modelBuilder.Entity("WebApi5.Data.Models.CategoryW", b =>
                {
                    b.Navigation("File");
                });
#pragma warning restore 612, 618
        }
    }
}
