using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class TareasDbContext : DbContext
    {
        //public IEnumerable<object> Usuarios { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario")
                .Property(p => p.Clave);

            modelBuilder.Entity<Tarea>()
                .ToTable("Tarea");
            
        }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
