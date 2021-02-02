using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Domain.Entities.Producciones
{
    public class Inventario : EntityBase
    {
        public string Tipo { get; private set; }

        public string TotalAnual { get; private set; }

        public string Adquisicion { get; private set; }

        public List<Producto> Productos { get; private set; }

        internal Inventario(string tipo, string totalAnual, string adquisicion, List<Producto> productos) : base()
        {
            if (string.IsNullOrEmpty(tipo))
            {
                throw new ArgumentNullException("el tipo de inventario es necesario");
            }
            else if(string.IsNullOrEmpty(totalAnual))
            {
                throw new ArgumentNullException("el total del año es necesario");
            }
            else if (string.IsNullOrEmpty(adquisicion))
            {
                throw new ArgumentNullException("el total del adquiciion es necesario");
            }
            else
            {
                this.Tipo = tipo;
                this.TotalAnual = totalAnual;
                this.Adquisicion = adquisicion;
                this.Productos = productos;
            }
        }

        private Inventario()
        {
            //necesario para EF
        }
    }
}
