using Quality.Application.Dtos;
using Quality.Domain.Entities.Producciones;
using Quality.Domain.Entities.Usuarios;
using Quality.Domain.Factories;
using Quality.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Quality.Application.ProduccionServices
{
    public class ProductoCommandServices
    {
        private readonly IRepository repository;

        private readonly IFactory factory;

        private readonly IAutoMapeo autoMapeo;

        public ProductoCommandServices(IRepository repository, IFactory factory, IAutoMapeo autoMapeo)
        {
            this.factory = factory;
            this.repository = repository;
            this.autoMapeo = autoMapeo;
        }

        internal async Task<ProductoConsultadoDto> CrearProducto(ProductoCreacionDto productoCreacionDto)
        {
            if (productoCreacionDto == null)
                throw new ArgumentNullException("es necesario los datos del producto para crearlo");

            //creamos el objeto de dominio y verifica que la entidad sea correcta
            var producto = factory.CrearProducto(productoCreacionDto.Descripcion, productoCreacionDto.Estado, productoCreacionDto.UsuarioId, productoCreacionDto.StockId,
                productoCreacionDto.InventarioId, productoCreacionDto.VentaId);


            //guardamos el objeto y luego lo mapeamos al dto correspondiente
            try
            {
                return autoMapeo.Map<Producto, ProductoConsultadoDto>( await repository.Guardar<Producto>((Producto)producto) );
            }
            catch (Exception e)
            {

                throw new Exception($"no se pudo guardar el usuario {e.Message}");
            }
        }
    }
}
