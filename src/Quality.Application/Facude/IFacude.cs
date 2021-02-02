using Quality.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Quality.Application.Facude
{
    public interface IFacude
    {
        public Task<ProductoConsultadoDto> CrearProducto(ProductoCreacionDto productoCreacionDto);
    }
}
