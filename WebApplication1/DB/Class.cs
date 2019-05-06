using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DB
{
    public class Class: DbContext
    {
        public Class(DbContextOptions<Class> options) : base(options) { }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Carro> Carro { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
