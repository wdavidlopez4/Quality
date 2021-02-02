using Quality.Domain.Entities.Producciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Domain.Entities.Usuarios
{
    public class Usuario : EntityBase
    {
        public string Nombre { get; private set; }

        public string Correo { get; private set; }

        public string Identificacion { get; private set; }

        public Rol Rol { get; private set; }

        public List<Producto> Productos { get; private set; }

        internal Usuario(string nombre, string correo, string identificacion, Rol rol, List<Producto> productos) : base()
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentNullException("el usuario no se puede crear sin nombre");
            }
            else if(string.IsNullOrWhiteSpace(correo))
            {
                throw new ArgumentNullException("el usuario no se puede crear sin correo");
            }
            else if (string.IsNullOrWhiteSpace(identificacion))
            {
                throw new ArgumentNullException("el usuario no se puede crear sin identificacion");
            }
            else
            {
                this.Nombre = nombre;
                this.Correo = correo;
                this.Identificacion = identificacion;
                this.Rol = rol;
                this.Productos = productos;
            }
        }

        private Usuario()
        {
            //necesario para EF
        }
    }
}
