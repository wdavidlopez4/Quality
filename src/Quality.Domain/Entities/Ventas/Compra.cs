using Quality.Domain.Entities.Producciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Domain.Entities.Ventas
{
    public class Compra : EntityBase
    {
        public int TotalProductos { get; private set; }

        public List<Producto> Productos { get; private set; }

        //PK de entidades
        public string FacturaId { get; private set; }

        public string OrdenDeCompraId { get; private set; }

        public string ResiboDeCajaId { get; private set; }

        //navegabilidad de objetos
        public Factura Factura { get; private set; }

        public OrdenDeCompra OrdenDeCompra { get; private set; }

        public ResiboDeCaja ResiboDeCaja { get; private set; }

        internal Compra(int totalProductos, string facturaId, string ordenDeCompraId, 
            string resiboDeCajaId, List<Producto> Productos) : base()
        {
            if (string.IsNullOrWhiteSpace(facturaId))
            {
                throw new ArgumentException("se necesita la factura");
            }
            else if (string.IsNullOrWhiteSpace(ordenDeCompraId))
            {
                throw new ArgumentException("se necesita la orden de compra");
            }
            else if (string.IsNullOrWhiteSpace(resiboDeCajaId))
            {
                throw new ArgumentException("se necesita el resivo de caja");
            }
            else
            {
                this.TotalProductos = totalProductos;
                this.FacturaId = facturaId;
                this.OrdenDeCompraId = ordenDeCompraId;
                this.ResiboDeCajaId = resiboDeCajaId;
                this.Productos = Productos;
            }
        }

        private Compra()
        {
            //necesario para EF
        }
    }
}
