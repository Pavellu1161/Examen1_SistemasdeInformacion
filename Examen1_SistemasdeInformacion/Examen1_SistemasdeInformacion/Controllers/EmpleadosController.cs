using Examen1_SistemasdeInformacion.Data;
using Examen1_SistemasdeInformacion.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen1_SistemasdeInformacion.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly ApplicationDbContext db;

        public EmpleadosController(ApplicationDbContext db)
        {

            this.db = db;

        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Empleados.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Empleado e)
        {
            if (ModelState.IsValid)
            {
                db.Add(e);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(e);
        }
    }
}
