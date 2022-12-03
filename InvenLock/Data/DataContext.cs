﻿using InvenLock.Models;
using Microsoft.EntityFrameworkCore;

namespace InvenLock.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<EstoqueEquipamento> Equipamentos { get; set; }

    }
}
