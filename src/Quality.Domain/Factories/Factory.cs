using Quality.Domain.Entities;
using Quality.Domain.Entities.Producciones;
using Quality.Domain.Entities.Usuarios;
using Quality.Domain.Entities.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Domain.Factories
{
    public class Factory : IFactory
    {
        public EntityBase CrearUsuario(string nombre, string correo, string identificacion, Rol rol, List<Producto> productos)
        {
            return new Usuario(nombre, correo, identificacion, rol, productos);
        }

        public EntityBase CrearInventario(string tipo, string totalAnual, string adquisicion, List<Producto> productos)
        {
            return new Inventario(tipo, totalAnual, adquisicion, productos);
        }

        public EntityBase CrearProducto(string descripcion, Estado estado, string usuarioId, string stockId, 
            string inventarioId, string ventaId)
        {
            return new Producto(descripcion, estado, usuarioId, stockId, inventarioId, ventaId);
        }

        public EntityBase CrearStrok(DateTime fechaInical, List<Producto> productos)
        {
            return new Stock(fechaInical, productos);
        }

        public EntityBase CrearCompra(int totalProductos, string facturaId, string ordenDeCompraId,
            string resiboDeCajaId, List<Producto> Productos)
        {
            return new Compra(totalProductos, facturaId, ordenDeCompraId, resiboDeCajaId, Productos);
        }

        public EntityBase CrearFactura(double totalAPagar, List<Compra> compras)
        {
            return new Factura(totalAPagar, compras);
        }

        public EntityBase CrearOrdenDeCompra(DateTime Fecha, string Lugar, List<Compra> compras)
        {
            return new OrdenDeCompra(Fecha, Lugar, compras);
        }

        public EntityBase CrearResiboDeCaja(string resividoDe, string sumadoDe, string conceptoDe, List<Compra> compras)
        {
            return new ResiboDeCaja(resividoDe, sumadoDe, conceptoDe, compras);
        }
    }
}
