using Microsoft.EntityFrameworkCore;
using RegistroPedidos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPedidos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Suplidores> Suplidores { get; set; }
        public DbSet<Productos> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"Data Source = Data/Ordenes.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>().HasData(new Productos
            { ProductoId = 1, Descripcion = "Platano", Costo = 55, Inventario = 57 });
            modelBuilder.Entity<Productos>().HasData(new Productos
            { ProductoId = 2, Descripcion = "RON", Costo = 30, Inventario = 53 });
            modelBuilder.Entity<Productos>().HasData(new Productos
            { ProductoId = 3, Descripcion = "Arroz", Costo = 45, Inventario = 30 });
            modelBuilder.Entity<Productos>().HasData(new Productos
            { ProductoId = 4, Descripcion = "Pizza", Costo = 500, Inventario = 1 });
            modelBuilder.Entity<Productos>().HasData(new Productos
            { ProductoId = 5, Descripcion = "Burguer king", Costo = 200, Inventario = 2 });


            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            { SuplidorId = 1, Nombres = "yoma super centro" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            { SuplidorId = 2, Nombres = "Brugal" });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            { SuplidorId = 3, Nombres = "Eufemio " });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            { SuplidorId = 4, Nombres = "Pizzeria 212 " });
            modelBuilder.Entity<Suplidores>().HasData(new Suplidores
            { SuplidorId = 5, Nombres = "haburguesa" });

        }
    }
}
