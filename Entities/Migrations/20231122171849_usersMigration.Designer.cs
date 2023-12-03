﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Entities.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20231122171849_usersMigration")]
    partial class usersMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Entities.Model.User.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("userid")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("birthday")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("dataLog")
                        .HasColumnType("integer");

                    b.Property<string>("firstname")
                        .HasColumnType("text");

                    b.Property<string>("lastname")
                        .HasColumnType("text");

                    b.Property<string>("login")
                        .HasColumnType("text");

                    b.Property<int>("organizationType")
                        .HasColumnType("integer");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<string>("pinfl")
                        .HasColumnType("text");

                    b.Property<int>("role")
                        .HasColumnType("integer");

                    b.Property<int>("status")
                        .HasColumnType("integer");

                    b.Property<string>("token")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            id = 1,
                            birthday = new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            dataLog = 0,
                            firstname = "Admin",
                            lastname = "Boss",
                            login = "admin",
                            organizationType = 0,
                            password = "admin",
                            role = 2,
                            status = 0
                        },
                        new
                        {
                            id = 2,
                            birthday = new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            dataLog = 0,
                            firstname = "User",
                            lastname = "Employer",
                            login = "user",
                            organizationType = 0,
                            password = "user",
                            role = 1,
                            status = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}