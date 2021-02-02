using Microsoft.AspNetCore.Mvc;
using Quality.Application.Dtos;
using Quality.Application.Facude;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quality.WebPresentation.Controllers
{
    public class ProductoController : Controller
    {
        //servicios del sistema encapsolados en  una fachada 
        private readonly IFacude facude;

        public ProductoController(IFacude facude)
        {
            this.facude = facude;
        }

        public IActionResult Index()
        {
            return View();
        }

        //contralador totalmente desacoplado 
        public async Task<IActionResult> CrearProducto(ProductoCreacionDto productoCreacionDto)
        {
            if (ModelState.IsValid)
            {
                var rest = await facude.CrearProducto(productoCreacionDto);
                return View(rest);
            }
            else
            {
                return BadRequest("el usuario no es valido");
            }
        }
    }
}
