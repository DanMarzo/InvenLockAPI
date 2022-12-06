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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataEmprestimo = new DateTime(2022, 12, 6, 17, 47, 5, 455, DateTimeKind.Local).AddTicks(9583),
                            IdForm = 1
                        });
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

                    b.Property<int?>("EstoqueEquipId")
                        .HasColumnType("int");

                    b.Property<int>("IdEquip")
                        .HasColumnType("int");

                    b.Property<int>("IdOcorrencia")
                        .HasColumnType("int");

                    b.Property<int?>("OcorrenciaId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstoqueEquipId");

                    b.HasIndex("OcorrenciaId");

                    b.ToTable("EquipManuts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataEntrada = new DateTime(2022, 12, 6, 17, 47, 5, 455, DateTimeKind.Local).AddTicks(9500),
                            Desc = "O infeliz molhou",
                            IdEquip = 2,
                            IdOcorrencia = 1,
                            Status = 2
                        });
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

                    b.HasIndex("EquipSucataId");

                    b.ToTable("EstoqueEquips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataCompra = new DateTime(2022, 12, 6, 17, 47, 5, 455, DateTimeKind.Local).AddTicks(9189),
                            Descricao = "Notebook empresarial",
                            Fabricante = 4,
                            NomeEquip = "DAN-DESKTOP-001",
                            Situacao = 4,
                            Tipo = 1
                        },
                        new
                        {
                            Id = 2,
                            DataCompra = new DateTime(2022, 12, 6, 17, 47, 5, 455, DateTimeKind.Local).AddTicks(9207),
                            Descricao = "Maquina empresarial em posse do Thiago",
                            Fabricante = 1,
                            NomeEquip = "THI-DESKTOP-002",
                            Situacao = 5,
                            Tipo = 2
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Emissao = new DateTime(2022, 12, 6, 17, 47, 5, 455, DateTimeKind.Local).AddTicks(9615),
                            IdEquipEmprestimo = 1,
                            IdFunc = 1,
                            IdTecnico = 1
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdFunc = 1,
                            TipoFunc = 3
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Admissao = new DateTime(2022, 12, 6, 17, 47, 5, 456, DateTimeKind.Local).AddTicks(1301),
                            Cpf = "12345678901",
                            Nome = "Dan",
                            PasswordHash = new byte[] { 248, 126, 126, 192, 224, 237, 109, 250, 123, 5, 47, 181, 43, 144, 221, 100, 250, 143, 92, 163, 87, 134, 71, 86, 38, 110, 159, 98, 153, 83, 57, 219, 115, 62, 170, 125, 127, 215, 88, 236, 245, 9, 106, 248, 110, 92, 177, 150, 11, 245, 3, 161, 234, 238, 54, 199, 250, 106, 198, 6, 34, 80, 113, 67 },
                            PasswordSalt = new byte[] { 123, 155, 155, 8, 130, 182, 155, 134, 38, 250, 229, 183, 121, 214, 173, 143, 29, 176, 205, 213, 60, 196, 176, 160, 107, 128, 186, 23, 154, 83, 52, 225, 225, 189, 94, 227, 7, 240, 150, 227, 63, 211, 233, 11, 186, 228, 229, 168, 62, 135, 207, 20, 27, 17, 55, 75, 250, 33, 2, 214, 90, 102, 111, 50, 213, 162, 221, 241, 194, 136, 39, 28, 164, 10, 111, 134, 83, 161, 12, 143, 144, 137, 228, 206, 101, 204, 138, 109, 165, 162, 198, 64, 94, 125, 50, 88, 208, 169, 233, 30, 161, 188, 83, 46, 31, 175, 26, 106, 56, 243, 232, 70, 4, 24, 1, 156, 11, 47, 78, 212, 109, 129, 140, 29, 233, 60, 197, 95 },
                            Situacao = 1,
                            SobreNome = "Marzo"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataOcorrencia = new DateTime(2022, 12, 6, 17, 47, 5, 455, DateTimeKind.Local).AddTicks(9546),
                            DescOcorrencia = "O infeliz deixo cair na agua",
                            IdEquip = 2,
                            IdFunc = 2
                        });
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
                    b.HasOne("InvenLock.Models.EstoqueEquip", "EstoqueEquip")
                        .WithMany()
                        .HasForeignKey("EstoqueEquipId");

                    b.HasOne("InvenLock.Models.Ocorrencia", "Ocorrencia")
                        .WithMany("EquipManutencao")
                        .HasForeignKey("OcorrenciaId");

                    b.Navigation("EstoqueEquip");

                    b.Navigation("Ocorrencia");
                });

            modelBuilder.Entity("InvenLock.Models.EstoqueEquip", b =>
                {
                    b.HasOne("InvenLock.Models.EquipEmprestimo", null)
                        .WithMany("EstoqueEquip")
                        .HasForeignKey("EquipEmprestimoId");

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

            modelBuilder.Entity("InvenLock.Models.EquipSucata", b =>
                {
                    b.Navigation("EstoqueEquip");
                });

            modelBuilder.Entity("InvenLock.Models.FormEmprestimo", b =>
                {
                    b.Navigation("EquipEmprestimo");
                });

            modelBuilder.Entity("InvenLock.Models.Ocorrencia", b =>
                {
                    b.Navigation("EquipManutencao");
                });
#pragma warning restore 612, 618
        }
    }
}
