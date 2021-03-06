﻿using Microsoft.EntityFrameworkCore;
using ClassLibrary.Entidades;

namespace WebApplication.Data
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario");

            modelBuilder.Entity<Tarea>()
                .ToTable("Tarea");

            modelBuilder.Entity<Detalle>()
                .ToTable("Detalle");

            modelBuilder.Entity<Recurso>()
                .ToTable("Recurso");
        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Tarea> Tarea { get; set; }

        public DbSet<Detalle> Detalle { get; set; }

        public DbSet<Recurso> Recurso { get; set; }
    }
}

