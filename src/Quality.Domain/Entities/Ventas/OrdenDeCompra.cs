using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Domain.Entities.Ventas
{
    public class OrdenDeCompra: EntityBase
    {
        public DateTime Fecha { get; private set; }

        public string Lugar { get; private set; }

        public List<Compra> Compras { get; private set; }

        internal OrdenDeCompra(DateTime Fecha, string Lugar, List<Compra> compras) : base()
        {
            this.Fecha = Fecha;
            this.Lugar = Lugar;
            this.Compras = compras;
        }

        private OrdenDeCompra()
        {
            //para EF
        }
    }
}
