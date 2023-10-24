using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SiteFinal.Models;

namespace SiteFinal.Controllers
{
    public class InformacaoController : Controller
    {
        private readonly Contexto _context;

        public InformacaoController(Contexto context)
        {
            _context = context;
        }

        // GET: Informacao
        public async Task<IActionResult> Index()
        {
              return _context.Informacao != null ? 
                          View(await _context.Informacao.ToListAsync()) :
                          Problem("Entity set 'Contexto.Informacao'  is null.");
        }

        // GET: Informacao/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Informacao == null)
            {
                return NotFound();
            }

            var informacao = await _context.Informacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (informacao == null)
            {
                return NotFound();
            }

            return View(informacao);
        }

        // GET: Informacao/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Informacao/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SaberMas,Oquesao")] Informacao informacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(informacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(informacao);
        }

        // GET: Informacao/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Informacao == null)
            {
                return NotFound();
            }

            var informacao = await _context.Informacao.FindAsync(id);
            if (informacao == null)
            {
                return NotFound();
            }
            return View(informacao);
        }

        // POST: Informacao/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SaberMas,Oquesao")] Informacao informacao)
        {
            if (id != informacao.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(informacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InformacaoExists(informacao.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(informacao);
        }

        // GET: Informacao/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Informacao == null)
            {
                return NotFound();
            }

            var informacao = await _context.Informacao
                .FirstOrDefaultAsync(m => m.Id == id);
            if (informacao == null)
            {
                return NotFound();
            }

            return View(informacao);
        }

        // POST: Informacao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Informacao == null)
            {
                return Problem("Entity set 'Contexto.Informacao'  is null.");
            }
            var informacao = await _context.Informacao.FindAsync(id);
            if (informacao != null)
            {
                _context.Informacao.Remove(informacao);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InformacaoExists(int id)
        {
          return (_context.Informacao?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
