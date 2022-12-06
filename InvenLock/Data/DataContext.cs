using InvenLock.Models;
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
    }
}
