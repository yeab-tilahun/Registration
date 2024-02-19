﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RegistrationBE;

#nullable disable

namespace RegistrationBE.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RegistrationBE.Models.Student", b =>
                {
                    b.Property<Guid?>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("CarInfo")
                        .HasColumnType("text");

                    b.Property<string>("ChurchExperiance")
                        .HasColumnType("text");

                    b.Property<string>("Debr")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool?>("HaveRepentFather")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool?>("LearnedBefore")
                        .HasColumnType("boolean");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<bool?>("NeedCar")
                        .HasColumnType("boolean");

                    b.Property<bool?>("OwnCar")
                        .HasColumnType("boolean");

                    b.Property<int?>("Phone")
                        .HasColumnType("integer");

                    b.Property<string>("PrefferedLocation")
                        .HasColumnType("text");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
