using Quality.Domain.Entities.Producciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Application.Dtos
{
    public class ProductoCreacionDto
    {
        public string Descripcion { get; set; }

        public Estado Estado { get; set; }

        //PK de entidades
        public string UsuarioId { get; set; }

        public string StockId { get; set; }

        public string InventarioId { get; set; }

        public string VentaId { get; set; }
    }
}
