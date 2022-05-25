using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Quintix_App_MVC.Data;
using Quintrix_Web_App_Core.Models;


namespace Quintix_App_MVC.Controllers
{
    public class PlayerModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlayerModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PlayerModels
        public async Task<IActionResult> Index()
        {
              return _context.PlayerModelDatas != null ? 
                          View(await _context.PlayerModelDatas.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.PlayerModelDatas'  is null.");
        }

        // GET: PlayerModels/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.PlayerModelDatas == null)
            {
                return NotFound();
            }

            var playerModel = await _context.PlayerModelDatas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playerModel == null)
            {
                return NotFound();
            }

            return View(playerModel);
        }

        // GET: PlayerModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlayerModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Level")] PlayerModel playerModel)
        {
            if (ModelState.IsValid)
            {
                playerModel.Id = Guid.NewGuid();
                _context.Add(playerModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(playerModel);
        }

        // GET: PlayerModels/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.PlayerModelDatas == null)
            {
                return NotFound();
            }

            var playerModel = await _context.PlayerModelDatas.FindAsync(id);
            if (playerModel == null)
            {
                return NotFound();
            }
            return View(playerModel);
        }

        // POST: PlayerModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Email,Level")] PlayerModel playerModel)
        {
            if (id != playerModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playerModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerModelExists(playerModel.Id))
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
            return View(playerModel);
        }

        // GET: PlayerModels/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.PlayerModelDatas == null)
            {
                return NotFound();
            }

            var playerModel = await _context.PlayerModelDatas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (playerModel == null)
            {
                return NotFound();
            }

            return View(playerModel);
        }

        // POST: PlayerModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.PlayerModelDatas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PlayerModelDatas'  is null.");
            }
            var playerModel = await _context.PlayerModelDatas.FindAsync(id);
            if (playerModel != null)
            {
                _context.PlayerModelDatas.Remove(playerModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerModelExists(Guid id)
        {
          return (_context.PlayerModelDatas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
