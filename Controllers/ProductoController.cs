using Microsoft.AspNetCore.Mvc;
using TechStore.Models;

namespace TechStore.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Index", "Home"); // Cambia "Index" y "Home" según tu estructura de la aplicación
            }
            return View(producto);
        }
    }
}
