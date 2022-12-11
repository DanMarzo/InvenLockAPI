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
        public DbSet<SucataEquip> SucataEquips { get;set; }
        public DbSet<Ocorrencia> Ocorrencias { get; set; }
        public DbSet<EmprestimoEquip> EmprestimoEquip { get; set; }
        public DbSet<FormEmprestimo> FormEmprestimos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FuncionarioContato> FuncionarioContatos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            Funcionario user = new Funcionario();
            Criptografia.CriarPasswordHash("1q2w3e4r", out byte[] hash, out byte[] salt);
            user.Id = 1;
            user.Nome = "Dan";
            user.Admissao = DateTime.Now;
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.PasswordString = string.Empty;
            user.Cpf = "12345678901";
            user.Situacao = SituacaoFuncEnum.Ativo;

            modelBuilder.Entity<Funcionario>().HasData(user);
        }
    }
}
