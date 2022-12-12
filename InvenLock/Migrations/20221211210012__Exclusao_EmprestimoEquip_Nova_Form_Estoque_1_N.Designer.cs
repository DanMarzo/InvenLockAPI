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
    [Migration("20221211210012__Exclusao_EmprestimoEquip_Nova_Form_Estoque_1_N")]
    partial class ExclusaoEmprestimoEquipNovaFormEstoque1N
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InvenLock.Models.EstoqueEquipamento", b =>
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

                    b.Property<int>("Fabricante")
                        .HasColumnType("int");

                    b.Property<string>("NomeEquip")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EstoqueEquipamentos");
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

                    b.Property<int>("EstoqueEquipamentoId")
                        .HasColumnType("int");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstoqueEquipamentoId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("FormEmprestimos");
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

                    b.Property<byte[]>("FotoFuncionario")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(20)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Situacao")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Admissao = new DateTime(2022, 12, 11, 18, 0, 12, 85, DateTimeKind.Local).AddTicks(2964),
                            Cpf = "12345678901",
                            Nome = "Dan",
                            PasswordHash = new byte[] { 87, 168, 234, 193, 33, 196, 12, 140, 152, 96, 78, 46, 148, 228, 121, 55, 254, 158, 69, 63, 214, 102, 133, 102, 56, 135, 209, 222, 74, 103, 5, 249, 57, 127, 182, 132, 232, 137, 193, 156, 146, 189, 67, 52, 29, 95, 88, 93, 96, 10, 156, 185, 36, 180, 74, 244, 142, 69, 196, 188, 107, 200, 170, 238 },
                            PasswordSalt = new byte[] { 31, 136, 211, 28, 195, 95, 167, 185, 111, 151, 187, 81, 102, 60, 141, 145, 20, 151, 26, 60, 107, 170, 103, 69, 179, 47, 92, 129, 177, 79, 185, 6, 181, 252, 84, 241, 174, 154, 165, 94, 29, 71, 223, 121, 214, 64, 1, 67, 100, 164, 160, 239, 52, 59, 185, 174, 226, 38, 212, 57, 165, 94, 77, 133, 247, 84, 19, 133, 172, 111, 211, 144, 147, 89, 109, 96, 25, 1, 42, 109, 206, 235, 37, 190, 189, 247, 116, 186, 254, 90, 244, 106, 46, 47, 211, 250, 99, 248, 63, 149, 73, 121, 180, 45, 2, 214, 199, 29, 18, 15, 6, 196, 151, 43, 2, 176, 134, 182, 14, 226, 112, 234, 249, 21, 135, 158, 48, 155 },
                            Situacao = 1
                        });
                });

            modelBuilder.Entity("InvenLock.Models.FuncionarioContato", b =>
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

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<string>("RamalCorporativo")
                        .HasColumnType("char(4)");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId")
                        .IsUnique();

                    b.ToTable("FuncionarioContatos");
                });

            modelBuilder.Entity("InvenLock.Models.ManutEquip", b =>
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

                    b.Property<int>("EstoqueEquipamentoId")
                        .HasColumnType("int");

                    b.Property<int>("OcorrenciaId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstoqueEquipamentoId")
                        .IsUnique();

                    b.HasIndex("OcorrenciaId")
                        .IsUnique();

                    b.ToTable("ManutEquips");
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

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Ocorrencias");
                });

            modelBuilder.Entity("InvenLock.Models.SucataEquip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime2");

                    b.Property<string>("DsOcorrido")
                        .HasColumnType("varchar(250)");

                    b.Property<int>("EstoqueEquipamentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstoqueEquipamentoId")
                        .IsUnique();

                    b.ToTable("SucataEquips");
                });

            modelBuilder.Entity("InvenLock.Models.FormEmprestimo", b =>
                {
                    b.HasOne("InvenLock.Models.EstoqueEquipamento", "EstoqueEquipamento")
                        .WithMany("FormEmprestimo")
                        .HasForeignKey("EstoqueEquipamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvenLock.Models.Funcionario", "Funcionario")
                        .WithMany("FormEmprestimo")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstoqueEquipamento");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("InvenLock.Models.FuncionarioContato", b =>
                {
                    b.HasOne("InvenLock.Models.Funcionario", "Funcionario")
                        .WithOne("FuncionarioContato")
                        .HasForeignKey("InvenLock.Models.FuncionarioContato", "FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("InvenLock.Models.ManutEquip", b =>
                {
                    b.HasOne("InvenLock.Models.EstoqueEquipamento", "EstoqueEquipamento")
                        .WithOne("ManutEquip")
                        .HasForeignKey("InvenLock.Models.ManutEquip", "EstoqueEquipamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InvenLock.Models.Ocorrencia", "Ocorrencia")
                        .WithOne("ManutEquip")
                        .HasForeignKey("InvenLock.Models.ManutEquip", "OcorrenciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstoqueEquipamento");

                    b.Navigation("Ocorrencia");
                });

            modelBuilder.Entity("InvenLock.Models.Ocorrencia", b =>
                {
                    b.HasOne("InvenLock.Models.Funcionario", "Funcionario")
                        .WithMany("Ocorrencia")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("InvenLock.Models.SucataEquip", b =>
                {
                    b.HasOne("InvenLock.Models.EstoqueEquipamento", "EstoqueEquipamento")
                        .WithOne("SucataEquip")
                        .HasForeignKey("InvenLock.Models.SucataEquip", "EstoqueEquipamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstoqueEquipamento");
                });

            modelBuilder.Entity("InvenLock.Models.EstoqueEquipamento", b =>
                {
                    b.Navigation("FormEmprestimo");

                    b.Navigation("ManutEquip");

                    b.Navigation("SucataEquip");
                });

            modelBuilder.Entity("InvenLock.Models.Funcionario", b =>
                {
                    b.Navigation("FormEmprestimo");

                    b.Navigation("FuncionarioContato");

                    b.Navigation("Ocorrencia");
                });

            modelBuilder.Entity("InvenLock.Models.Ocorrencia", b =>
                {
                    b.Navigation("ManutEquip");
                });
#pragma warning restore 612, 618
        }
    }
}
