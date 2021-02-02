using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Domain.Entities.Producciones
{
    public class Stock : EntityBase
    {
        public DateTime FechaInical { get; private set; }

        public List<Producto> Productos { get; private set; }

        internal Stock(DateTime fechaInical, List<Producto> productos):base()
        {
            if (fechaInical == null)
            {
                throw new ArgumentNullException("ES NECESARIA LA FECHA para la creacion del strok");
            }
            else
            {
                this.FechaInical = fechaInical;
                this.Productos = productos;
            }
        }

        private Stock()
        {
            //necesario para EF
        }
    }
}
