using Quality.Domain.Entities.Usuarios;
using Quality.Domain.Entities.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Domain.Entities.Producciones
{
    public class Producto : EntityBase
    {
        public string Descripcion { get; private set; }

        public Estado Estado { get; private set; }

        //PK de entidades
        public string UsuarioId { get; private set; }

        public string StockId { get; private set; }

        public string InventarioId { get; private set; }

        public string VentaId { get; private set; }

        //navegabilidad de objetos
        public Usuario Usuario { get; private set; }

        public Stock Stock { get; private set; }

        public Inventario Inventario { get; private set; }

        public Compra Compra { get; private set; }

        internal Producto(string descripcion, Estado estado, string usuarioId, string stockId, string inventarioId, string ventaId) : base()
        {
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new ArgumentNullException("para crear el producto es necesario la descripcion");
            }
            else if (string.IsNullOrWhiteSpace(usuarioId))
            {
                throw new ArgumentNullException("para crear el producto es necesario el usuario");
            }
            else if (string.IsNullOrWhiteSpace(stockId))
            {
                throw new ArgumentNullException("para crear el producto es necesario el strock");
            }
            else if (string.IsNullOrWhiteSpace(inventarioId))
            {
                throw new ArgumentNullException("para crear el producto es necesario el inventario");
            }
            else
            {
                this.Descripcion = descripcion;
                this.Estado = Estado;
                this.UsuarioId = usuarioId;
                this.StockId = stockId;
                this.InventarioId = inventarioId;
                this.VentaId = ventaId;
            }
        }

        private Producto()
        {
            //necesario para EF
        }

    }
}
