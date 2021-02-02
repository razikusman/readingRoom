﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReadingRoomStore.Models;

namespace ReadingRoomStore.Migrations
{
    [DbContext(typeof(ReadingRoomDBContext))]
    [Migration("20210104055540__BooksTableCreated")]
    partial class _BooksTableCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ReadingRoomStore.Models.Books", b =>
                {
                    b.Property<int>("BooksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BooKsMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BooksAouthers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BooksName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BooksPublishers")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BooksId");

                    b.ToTable("books");
                });
#pragma warning restore 612, 618
        }
    }
}
