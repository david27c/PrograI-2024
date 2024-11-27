using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Segundo_Avanse_2.Pagina_web_mascotas.Controlador
{
    public class MascotasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MascotasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Crear la lista de mascotas usando Entity Framework Core
            var mascotas = await _context.Mascotas.ToListAsync();
            return View(mascotas);
        }
    }
}


