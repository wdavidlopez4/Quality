using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Domain.Entities.Ventas
{
    public class Factura : EntityBase
    {
        public double TotalAPagar { get; private set; }

        public List<Compra> Compras { get; private set; }

        internal Factura(double totalAPagar, List<Compra> compras): base()
        {
            this.TotalAPagar = totalAPagar;
            this.Compras = compras;
        }

        private Factura()
        {
            //necesario para EF
        }
    }
}
