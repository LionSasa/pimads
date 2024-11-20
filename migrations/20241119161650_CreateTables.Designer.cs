﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace projetopim.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241119161650_CreateTables")]
    partial class CreateTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CultivosEInsumos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cultivo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CultivoId")
                        .HasColumnType("integer");

                    b.Property<string>("Fornecedor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("integer");

                    b.Property<string>("Insumo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("InsumoId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("CultivosEInsumos");
                });

            modelBuilder.Entity("Vendas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Cliente")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ClienteId")
                        .HasColumnType("integer");

                    b.Property<string>("FormaDePagamento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Produto")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
