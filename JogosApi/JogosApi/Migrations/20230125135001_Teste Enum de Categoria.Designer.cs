﻿// <auto-generated />
using System;
using JogosApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JogosApi.Migrations
{
    [DbContext(typeof(JogoContext))]
    [Migration("20230125135001_Teste Enum de Categoria")]
    partial class TesteEnumdeCategoria
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JogosApi.Entities.Enums.Generos.EnumCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("EnumCategoria");
                });

            modelBuilder.Entity("JogosApi.Models.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CriadoPor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DataLancamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnumCategoria1Id")
                        .HasColumnType("int");

                    b.Property<int?>("EnumCategoria2Id")
                        .HasColumnType("int");

                    b.Property<int?>("EnumCategoria3Id")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plataforma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Proprietario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EnumCategoria1Id");

                    b.HasIndex("EnumCategoria2Id");

                    b.HasIndex("EnumCategoria3Id");

                    b.ToTable("TB_GAMES");
                });

            modelBuilder.Entity("JogosApi.Models.Jogo", b =>
                {
                    b.HasOne("JogosApi.Entities.Enums.Generos.EnumCategoria", "EnumCategoria1")
                        .WithMany()
                        .HasForeignKey("EnumCategoria1Id");

                    b.HasOne("JogosApi.Entities.Enums.Generos.EnumCategoria", "EnumCategoria2")
                        .WithMany()
                        .HasForeignKey("EnumCategoria2Id");

                    b.HasOne("JogosApi.Entities.Enums.Generos.EnumCategoria", "EnumCategoria3")
                        .WithMany()
                        .HasForeignKey("EnumCategoria3Id");

                    b.Navigation("EnumCategoria1");

                    b.Navigation("EnumCategoria2");

                    b.Navigation("EnumCategoria3");
                });
#pragma warning restore 612, 618
        }
    }
}
