﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyBlog.Persistence;

namespace MyBlog.Persistence.Migrations
{
    [DbContext(typeof(MyBlogDbContext))]
    [Migration("20190623161911_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyBlog.Domain.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnName("CategoryID");

                    b.Property<int?>("CategoryId1");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("IsDraft");

                    b.Property<DateTime?>("PostedDate");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Tags");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("UserId")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId1");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("MyBlog.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MyBlog.Domain.Entities.Blog", b =>
                {
                    b.HasOne("MyBlog.Domain.Entities.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId1");
                });
#pragma warning restore 612, 618
        }
    }
}
