﻿// <auto-generated />
using System;
using InvenLock.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InvenLock.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221127021736_TabelaPerifericos")]
    partial class TabelaPerifericos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InvenLock.Models.Periferico", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Codigo"));

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataFimEquip")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fabricante")
                        .HasColumnType("int");

                    b.Property<string>("NomeEquip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SituacaoEquip")
                        .HasColumnType("int");

                    b.Property<int>("TipoEquipamento")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.ToTable("Perifericos");
                });
#pragma warning restore 612, 618
        }
    }
}
