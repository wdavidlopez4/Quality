using Quality.Domain.Entities;
using Quality.Domain.Entities.Producciones;
using Quality.Domain.Entities.Usuarios;
using Quality.Domain.Entities.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Domain.Factories
{
    public interface IFactory
    {
        public EntityBase CrearUsuario(string nombre, string correo, string identificacion, Rol rol, List<Producto> productos);


        public EntityBase CrearInventario(string tipo, string totalAnual, string adquisicion, List<Producto> productos);


        public EntityBase CrearProducto(string descripcion, Estado estado, string usuarioId, string stockId,
            string inventarioId, string ventaId);


        public EntityBase CrearStrok(DateTime fechaInical, List<Producto> productos);


        public EntityBase CrearCompra(int totalProductos, string facturaId, string ordenDeCompraId,
            string resiboDeCajaId, List<Producto> Productos);


        public EntityBase CrearFactura(double totalAPagar, List<Compra> compras);


        public EntityBase CrearOrdenDeCompra(DateTime Fecha, string Lugar, List<Compra> compras);


        public EntityBase CrearResiboDeCaja(string resividoDe, string sumadoDe, string conceptoDe, List<Compra> compras);

    }
}
