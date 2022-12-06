using InvenLock.Models;
using InvenLock.Models.Enums;
using InvenLock.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace InvenLock.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<EstoqueEquip>    EstoqueEquips    { get; set; }
        public DbSet<EquipEmprestimo> EquipEmprestimo  { get; set; }
        public DbSet<ContatoFunc>     ContatoFuncs     { get; set; }
        public DbSet<EquipManut>      EquipManuts      { get; set; }
        public DbSet<EquipSucata>     EquipSucatas     { get; set; }
        public DbSet<FormEmprestimo>  FormEmprestimos  { get; set; }
        public DbSet<FuncInfra>       FuncInfras       { get; set; }
        public DbSet<Funcionario>     Funcionarios     { get; set; }
        public DbSet<Ocorrencia>      Ocorrencias      { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstoqueEquip>().HasData(
                new EstoqueEquip() { 
                    Id = 1, 
                    Tipo = TipoEquipEnum.Notebook, 
                    Situacao = StatusEquipEnum.Emprestado, 
                    NomeEquip = "DAN-DESKTOP-001", 
                    Fabricante = FabEnum.Asus, 
                    Descricao = "Notebook empresarial", 
                    DataCompra = DateTime.Now },
                new EstoqueEquip()
                {
                    Id = 2,
                    Tipo = TipoEquipEnum.Desktop,
                    Situacao = StatusEquipEnum.Manutenção,
                    NomeEquip = "THI-DESKTOP-002",
                    Fabricante = FabEnum.Samsung,
                    Descricao = "Maquina empresarial em posse do Thiago", DataCompra = DateTime.Now
                });
            modelBuilder.Entity<EquipManut>().HasData(
                new EquipManut
                {
                    Id = 1,
                    IdOcorrencia = 1,
                    DataEntrada = DateTime.Now,
                    Desc = "O infeliz molhou",
                    Status = StatusManuEnum.Pendente,
                    IdEquip = 2,
                });
            modelBuilder.Entity<Ocorrencia>().HasData(
                new Ocorrencia 
                { 
                    Id = 1,
                    DataOcorrencia = DateTime.Now,
                    DescOcorrencia = "O infeliz deixo cair na agua",
                    IdFunc = 2,
                    IdEquip = 2,
                });
            modelBuilder.Entity<EquipEmprestimo>().HasData(
                new EquipEmprestimo
                {
                    Id = 1,
                    DataEmprestimo = DateTime.Now,
                    IdForm = 1,
                });
            modelBuilder.Entity<FormEmprestimo>().HasData(
                new FormEmprestimo
                {
                    Id = 1,
                    Emissao = DateTime.Now,
                    IdEquipEmprestimo = 1,
                    IdFunc = 1,
                    IdTecnico = 1
                });

            Funcionario user = new Funcionario();
            Criptografia.CriarPasswordHash("1q2w3e4r", out byte[] hash, out byte[] salt);
            user.Id             = 1;
            user.Nome           = "Dan";
            user.Admissao       = DateTime.Now;
            user.PasswordHash   = hash;
            user.PasswordSalt   = salt;
            user.PasswordString = string.Empty;
            user.Cpf            = "12345678901";
            user.SobreNome      = "Marzo";
            user.Situacao       = SituacaoFuncEnum.Ativo;

            modelBuilder.Entity<Funcionario>().HasData(user);


            modelBuilder.Entity<FuncInfra>().HasData(
                new FuncInfra
                {
                    Id       = 1,
                    IdFunc   = 1,
                    TipoFunc = FuncInfraEnum.Tecnico
                });
        }
    }
}
