using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using studyBuddy.Data;
using studyBuddy.Models;

namespace studyBuddy.Controllers
{
    public class PdfLinksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PdfLinksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PdfLinks
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PdfLinks.Include(p => p.Pdf);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PdfLinks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pdfLink = await _context.PdfLinks
                .Include(p => p.Pdf)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pdfLink == null)
            {
                return NotFound();
            }

            return View(pdfLink);
        }

        // GET: PdfLinks/Create
        public IActionResult Create()
        {
            ViewData["PdfId"] = new SelectList(_context.Pdfs, "Id", "Id");
            return View();
        }

        // POST: PdfLinks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PdfId,FileName")] PdfLink pdfLink)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pdfLink);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PdfId"] = new SelectList(_context.Pdfs, "Id", "Id", pdfLink.PdfId);
            return View(pdfLink);
        }

        // GET: PdfLinks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pdfLink = await _context.PdfLinks.FindAsync(id);
            if (pdfLink == null)
            {
                return NotFound();
            }
            ViewData["PdfId"] = new SelectList(_context.Pdfs, "Id", "Id", pdfLink.PdfId);
            return View(pdfLink);
        }

        // POST: PdfLinks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PdfId,FileName")] PdfLink pdfLink)
        {
            if (id != pdfLink.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pdfLink);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PdfLinkExists(pdfLink.Id))
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
            ViewData["PdfId"] = new SelectList(_context.Pdfs, "Id", "Id", pdfLink.PdfId);
            return View(pdfLink);
        }

        // GET: PdfLinks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pdfLink = await _context.PdfLinks
                .Include(p => p.Pdf)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pdfLink == null)
            {
                return NotFound();
            }

            return View(pdfLink);
        }

        // POST: PdfLinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pdfLink = await _context.PdfLinks.FindAsync(id);
            _context.PdfLinks.Remove(pdfLink);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PdfLinkExists(int id)
        {
            return _context.PdfLinks.Any(e => e.Id == id);
        }
    }
}
