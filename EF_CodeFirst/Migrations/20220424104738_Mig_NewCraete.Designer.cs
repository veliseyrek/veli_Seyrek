﻿// <auto-generated />
using System;
using EF_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_CodeFirst.Migrations
{
    [DbContext(typeof(Library6Context))]
    [Migration("20220424104738_Mig_NewCraete")]
    partial class Mig_NewCraete
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF_CodeFirst.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AuthorDateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("EF_CodeFirst.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BookEditionNumber")
                        .HasColumnType("int");

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookNumberOfPages")
                        .HasColumnType("int");

                    b.Property<int>("BookQuantity")
                        .HasColumnType("int");

                    b.Property<int>("BookYearOfPublication")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("EF_CodeFirst.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EF_CodeFirst.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MemberDateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("MemberJob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MemberJoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MemberMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("EF_CodeFirst.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PublisherAmil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublisherCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublisherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("EF_CodeFirst.Models.Book", b =>
                {
                    b.HasOne("EF_CodeFirst.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_CodeFirst.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_CodeFirst.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("EF_CodeFirst.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EF_CodeFirst.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("EF_CodeFirst.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
