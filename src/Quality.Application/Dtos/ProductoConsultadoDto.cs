using Quality.Domain.Entities.Producciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quality.Application.Dtos
{
    public class ProductoConsultadoDto
    {
        public string Descripcion { get; private set; }

        public Estado Estado { get; private set; }

        //PK de entidades
        public string UsuarioId { get; private set; }

        public string StockId { get; private set; }

        public string InventarioId { get; private set; }

        public string VentaId { get; private set; }
    }
}
