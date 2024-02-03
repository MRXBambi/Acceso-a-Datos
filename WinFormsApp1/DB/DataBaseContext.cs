using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Moldes;

namespace WinFormsApp1.DB
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto_Ventas> Productos_Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Coderhouse")
        }
    }
}
