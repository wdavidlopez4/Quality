using Microsoft.EntityFrameworkCore;
using Quality.Domain.Entities.Producciones;
using Quality.Domain.Entities.Usuarios;
using Quality.Domain.Entities.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Infrastructura.EF
{
    public class QualityContext : DbContext 
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Inventario> Inventarios { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Compra> Compras { get; set; }

        public DbSet<Factura> Facturas { get; set; }

        public DbSet<OrdenDeCompra> OrdenDeCompras { get; set; }

        public DbSet<ResiboDeCaja> ResiboDeCajas { get; set; }


        public QualityContext(DbContextOptions options) : base(options)
        {

        }
    }
}
