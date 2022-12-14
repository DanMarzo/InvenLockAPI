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
        public DbSet<EstoqueEquipamento> EstoqueEquipamentos { get;set; }
        public DbSet<ManutEquip> ManutEquips { get;set; }
        public DbSet<Ocorrencia> Ocorrencias { get; set; }
        //public DbSet<EmprestimoEquip> EmprestimoEquip { get; set; }
        public DbSet<FormEmprestimo> FormEmprestimos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        //public DbSet<FuncionarioContato> FuncionarioContatos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*ManutEquip manut = new();
            manut.DataEntrada = DateTime.Now;
            manut.Desc = "miseravi";
            manut.EstoqueEquipamentoId = 1;
            manut.Situacao = SituacaoManuEnum.Pendente;
            modelBuilder.Entity<Funcionario>().HasData(manut);
            */
            modelBuilder.Entity<ManutEquip>().Property(f => f.Situacao).HasDefaultValue(SituacaoManuEnum.Pendente);
            
            modelBuilder.Entity<Ocorrencia>().Property(f => f.Situacao).HasDefaultValue(SituacaoFuncOcoEnum.Ativo);

            modelBuilder.Entity<Funcionario>().Property(f => f.Situacao).HasDefaultValue(SituacaoFuncOcoEnum.Ativo);
            Funcionario user = new();
            Criptografia.CriarPasswordHash("1q2w3e4r", out byte[] hash, out byte[] salt);
            user.Id = 1;
            user.Nome = "Dan";
            user.Admissao = DateTime.Now;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.PasswordString = string.Empty;
            user.Cpf = "12345678901";
            user.Situacao = SituacaoFuncOcoEnum.Ativo;
            user.CelPessoal = "11955008212";
            user.Ramal = "1010";
            user.EmailCorp = "marzogildan@invenlock.com";
            user.EmailPessoal = "marzogildan@gmail.com";

            modelBuilder.Entity<Funcionario>().HasData(user);
        }
    }
}
