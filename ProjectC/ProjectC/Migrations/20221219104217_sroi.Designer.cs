﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProjectC.Models;

#nullable disable

namespace ProjectC.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20221219104217_sroi")]
    partial class sroi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("EF")
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProjectC.Models.Account", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("accounts", "EF");
                });

            modelBuilder.Entity("ProjectC.Models.Innovation", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("amount")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("hoursSavings")
                        .HasColumnType("integer");

                    b.Property<double>("implementCosts")
                        .HasColumnType("double precision");

                    b.Property<int>("implementHours")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("personelSavings")
                        .HasColumnType("double precision");

                    b.Property<double>("price")
                        .HasColumnType("double precision");

                    b.Property<double>("sroi")
                        .HasColumnType("double precision");

                    b.HasKey("id");

                    b.ToTable("innovations", "EF");
                });
#pragma warning restore 612, 618
        }
    }
}