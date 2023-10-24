﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiteFinal.Models;

#nullable disable

namespace SiteFinal.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231024162226_Criacao-Site-Final2")]
    partial class CriacaoSiteFinal2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SiteFinal.Models.CadastroProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Produto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descricao");

                    b.HasKey("Id");

                    b.ToTable("CadastroProduto");
                });

            modelBuilder.Entity("SiteFinal.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MarcaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeMarca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeMarca");

                    b.Property<int>("PrecoMarca")
                        .HasColumnType("int")
                        .HasColumnName("PrecoMarca");

                    b.HasKey("Id");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("SiteFinal.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Pessoa");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IdadePessoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Idade");

                    b.Property<string>("NomePessoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Sexo");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("SiteFinal.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Produto");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataValidade")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataValidade");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descricao");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Observacao");

                    b.Property<string>("Peso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Peso");

                    b.Property<double>("Preco")
                        .HasColumnType("float")
                        .HasColumnName("Preco");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}