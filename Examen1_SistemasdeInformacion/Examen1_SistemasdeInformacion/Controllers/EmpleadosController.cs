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
        public async Task<ActionResult> Index(string search)
        {
            if (search == null)
            {
                return View(await db.Empleados.ToListAsync());
            }

            return View(await db.Empleados
                .Where(b => b.EmpleadoNombres.Contains(search))
                .ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var e = await db.Empleados.FirstOrDefaultAsync(e => e.EmpleadoId == id);

            if (e == null)
            {
                return NotFound();
            }

            return View(e);
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

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var e = await db.Empleados.FindAsync(id);

            if (e == null)
            {
                return NotFound();
            }

            return View(e);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Empleado e)
        {
            if (id != e.EmpleadoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(e);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(e);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var e = await db.Empleados.FirstOrDefaultAsync(m => m.EmpleadoId == id);

            if (e == null)
            {
                return NotFound();
            }

            return View(e);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var e = await db.Empleados.FindAsync(id);
            db.Empleados.Remove(e);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    
}
}
