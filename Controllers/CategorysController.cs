using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaoShop.Models.DB;

namespace TaoShop.Controllers
{
    public class CategorysController : Controller
    {
        private readonly aspnetTaoShopContext _context;

        public CategorysController(aspnetTaoShopContext context)
        {
            _context = context;
        }

        // GET: Categorys
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categorys.ToListAsync());
        }

        // GET: Categorys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorys = await _context.Categorys
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categorys == null)
            {
                return NotFound();
            }

            return View(categorys);
        }

        // GET: Categorys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categorys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Parent,Slug,Status,CreatedAt,UpdatedAt")] Categorys categorys)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categorys);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categorys);
        }

        // GET: Categorys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorys = await _context.Categorys.FindAsync(id);
            if (categorys == null)
            {
                return NotFound();
            }
            return View(categorys);
        }

        // POST: Categorys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Parent,Slug,Status,CreatedAt,UpdatedAt")] Categorys categorys)
        {
            if (id != categorys.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categorys);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategorysExists(categorys.Id))
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
            return View(categorys);
        }

        // GET: Categorys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categorys = await _context.Categorys
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categorys == null)
            {
                return NotFound();
            }

            return View(categorys);
        }

        // POST: Categorys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categorys = await _context.Categorys.FindAsync(id);
            _context.Categorys.Remove(categorys);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategorysExists(int id)
        {
            return _context.Categorys.Any(e => e.Id == id);
        }
    }
}
