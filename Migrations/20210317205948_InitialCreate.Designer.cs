﻿// <auto-generated />
using CharacterManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CharacterManager.Migrations
{
    [DbContext(typeof(CharacterContext))]
    [Migration("20210317205948_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CharacterManager.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cha")
                        .HasColumnType("int");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Con")
                        .HasColumnType("int");

                    b.Property<int>("Dex")
                        .HasColumnType("int");

                    b.Property<int>("Int")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolledHP")
                        .HasColumnType("int");

                    b.Property<int>("Str")
                        .HasColumnType("int");

                    b.Property<int>("Wis")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Character");
                });
#pragma warning restore 612, 618
        }
    }
}
