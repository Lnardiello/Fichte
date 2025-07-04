﻿// <auto-generated />
using Fichte.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Fichte.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20250628145210_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Fichte.Models.Message", b =>
                {
                    b.Property<int>("IDMessage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDMessage"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("IDMessage");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Fichte.Models.User", b =>
                {
                    b.Property<int>("IDUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDUser"));

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IDUser");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
