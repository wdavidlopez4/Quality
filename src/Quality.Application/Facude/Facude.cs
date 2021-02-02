using Quality.Application.Dtos;
using Quality.Application.ProduccionServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Quality.Application.Facude
{
    public class Facude : IFacude
    {
        private readonly ProductoCommandServices productoCommandService;

        public Facude(ProductoCommandServices productoCommandService)
        {
            this.productoCommandService = productoCommandService;
        }

        public async Task<ProductoConsultadoDto> CrearProducto(ProductoCreacionDto productoCreacionDto)
        {
            return await this.productoCommandService.CrearProducto(productoCreacionDto);
        }
    }
}
