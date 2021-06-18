using Examen_Grupo_3_Jefferson_Lara.Data;
using Examen_Grupo_3_Jefferson_Lara.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Grupo_3_Jefferson_Lara.Controllers
{
    public class FormatoController : Controller
    {
        private readonly ApplicationDbContext db;

        public FormatoController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index(string search)
        {
            if (search == null)
            {
                return View(await db.FormatosAcosoLaboral.ToListAsync());
            }
            return View(await db.FormatosAcosoLaboral.Where(f => f.Nombre.Contains(search)).ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formato = await db.FormatosAcosoLaboral.FirstOrDefaultAsync(f => f.Id == id);

            if (formato == null)
            {
                return NotFound();
            }

            return View(formato);

        }

        //Crear

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FormatoAcosoLaboral formato)
        {
            if (ModelState.IsValid)
            {
                db.Add(formato);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formato);
        }

        //Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formato = await db.FormatosAcosoLaboral.FindAsync(id);

            if (formato == null)
            {
                return NotFound();
            }

            return View(formato);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FormatoAcosoLaboral formato)
        {
            if (id != formato.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(formato);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(formato);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formato = await db.FormatosAcosoLaboral.FirstOrDefaultAsync(F => F.Id == id);

            if (formato == null)
            {
                return NotFound();
            }

            return View(formato);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Delete(int id)
        {
            var formato = await db.FormatosAcosoLaboral.FindAsync(id);
            db.FormatosAcosoLaboral.Remove(formato);
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
