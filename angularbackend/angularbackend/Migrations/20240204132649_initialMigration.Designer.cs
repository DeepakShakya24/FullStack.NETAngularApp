﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using angularbackend.Data;

#nullable disable

namespace angularbackend.Migrations
{
    [DbContext(typeof(ngDBContext))]
    [Migration("20240204132649_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("angularbackend.Models.Employees", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("departmnet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("AngularEmployee", (string)null);

                    b.HasData(
                        new
                        {
                            id = "e2fb4ab6-9815-4fca-8e6f-f42558ec32fe",
                            departmnet = "IT",
                            email = "d.sha@acc.com",
                            firstName = "Deepak",
                            lastName = "Shakya"
                        },
                        new
                        {
                            id = "f181f417-0650-4a1c-ac16-3027ad0696bb",
                            departmnet = "BDE",
                            email = "shanal.tripathu@acc.com",
                            firstName = "Shanal",
                            lastName = "Tripathi"
                        },
                        new
                        {
                            id = "1d155d12-dcde-4a97-9f38-c60de802c75b",
                            departmnet = "Writer",
                            email = "richa.dubey@acc.com",
                            firstName = "Richa",
                            lastName = "Dubey"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
