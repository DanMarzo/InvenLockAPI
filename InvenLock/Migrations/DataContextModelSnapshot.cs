﻿// <auto-generated />
using System;
using InvenLock.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InvenLock.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InvenLock.Models.ContatoFunc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CelPessoal")
                        .HasColumnType("char(11)");

                    b.Property<string>("EmailCorporativo")
                        .HasColumnType("varchar(70)");

                    b.Property<string>("EmailPessoal")
                        .HasColumnType("varchar(70)");

                    b.Property<int?>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<string>("RamalCorporativo")
                        .HasColumnType("char(4)");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("ContatoFuncs");
                });

            modelBuilder.Entity("InvenLock.Models.EquipEmprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEmprestimo")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FormEmprestimoId")
                        .HasColumnType("int");

                    b.Property<int>("IdForm")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FormEmprestimoId");

                    b.ToTable("EquipEmprestimo");
                });

            modelBuilder.Entity("InvenLock.Models.EquipManut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataSaida")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .HasColumnType("varchar(250)");

                    b.Property<int>("IdOcorrencia")
                        .HasColumnType("int");

                    b.Property<int?>("OcorrenciaId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OcorrenciaId");

                    b.ToTable("EquipManuts");
                });

            modelBuilder.Entity("InvenLock.Models.EquipSucata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime2");

                    b.Property<string>("DsOcorrido")
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("EquipSucatas");
                });

            modelBuilder.Entity("InvenLock.Models.EstoqueEquip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataFimEquip")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(250)");

                    b.Property<int?>("EquipEmprestimoId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipManutId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipSucataId")
                        .HasColumnType("int");

                    b.Property<int>("Fabricante")
                        .HasColumnType("int");

                    b.Property<string>("NomeEquip")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipEmprestimoId");

                    b.HasIndex("EquipManutId");

                    b.HasIndex("EquipSucataId");

                    b.ToTable("EstoqueEquips");
                });

            modelBuilder.Entity("InvenLock.Models.FormEmprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Devolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Emissao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FuncInfraId")
                        .HasColumnType("int");

                    b.Property<int?>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<int>("IdEquipEmprestimo")
                        .HasColumnType("int");

                    b.Property<int>("IdFunc")
                        .HasColumnType("int");

                    b.Property<int>("IdTecnico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FuncInfraId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("FormEmprestimos");
                });

            modelBuilder.Entity("InvenLock.Models.FuncInfra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<int>("IdFunc")
                        .HasColumnType("int");

                    b.Property<int>("TipoFunc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("FuncInfras");
                });

            modelBuilder.Entity("InvenLock.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Admissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cpf")
                        .HasColumnType("char(11)");

                    b.Property<DateTime?>("Demissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(20)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.Property<string>("SobreNome")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("InvenLock.Models.Ocorrencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataOcorrencia")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescOcorrencia")
                        .HasColumnType("varchar(250)");

                    b.Property<int?>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<int>("IdEquip")
                        .HasColumnType("int");

                    b.Property<int>("IdFunc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Ocorrencias");
                });

            modelBuilder.Entity("InvenLock.Models.ContatoFunc", b =>
                {
                    b.HasOne("InvenLock.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("InvenLock.Models.EquipEmprestimo", b =>
                {
                    b.HasOne("InvenLock.Models.FormEmprestimo", "FormEmprestimo")
                        .WithMany("EquipEmprestimo")
                        .HasForeignKey("FormEmprestimoId");

                    b.Navigation("FormEmprestimo");
                });

            modelBuilder.Entity("InvenLock.Models.EquipManut", b =>
                {
                    b.HasOne("InvenLock.Models.Ocorrencia", "Ocorrencia")
                        .WithMany()
                        .HasForeignKey("OcorrenciaId");

                    b.Navigation("Ocorrencia");
                });

            modelBuilder.Entity("InvenLock.Models.EstoqueEquip", b =>
                {
                    b.HasOne("InvenLock.Models.EquipEmprestimo", null)
                        .WithMany("EstoqueEquip")
                        .HasForeignKey("EquipEmprestimoId");

                    b.HasOne("InvenLock.Models.EquipManut", null)
                        .WithMany("EstoqueEquip")
                        .HasForeignKey("EquipManutId");

                    b.HasOne("InvenLock.Models.EquipSucata", null)
                        .WithMany("EstoqueEquip")
                        .HasForeignKey("EquipSucataId");
                });

            modelBuilder.Entity("InvenLock.Models.FormEmprestimo", b =>
                {
                    b.HasOne("InvenLock.Models.FuncInfra", "FuncInfra")
                        .WithMany()
                        .HasForeignKey("FuncInfraId");

                    b.HasOne("InvenLock.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId");

                    b.Navigation("FuncInfra");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("InvenLock.Models.FuncInfra", b =>
                {
                    b.HasOne("InvenLock.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("InvenLock.Models.Ocorrencia", b =>
                {
                    b.HasOne("InvenLock.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("InvenLock.Models.EquipEmprestimo", b =>
                {
                    b.Navigation("EstoqueEquip");
                });

            modelBuilder.Entity("InvenLock.Models.EquipManut", b =>
                {
                    b.Navigation("EstoqueEquip");
                });

            modelBuilder.Entity("InvenLock.Models.EquipSucata", b =>
                {
                    b.Navigation("EstoqueEquip");
                });

            modelBuilder.Entity("InvenLock.Models.FormEmprestimo", b =>
                {
                    b.Navigation("EquipEmprestimo");
                });
#pragma warning restore 612, 618
        }
    }
}
