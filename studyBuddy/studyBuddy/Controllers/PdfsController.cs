﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using studyBuddy.Data;
using studyBuddy.Models;
using Microsoft.AspNetCore.Hosting;
namespace studyBuddy.Controllers
{
    public class PdfsController : Controller
    {
        private readonly ApplicationDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _environment;

        [Obsolete]
        public PdfsController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Pdfs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pdfs.ToListAsync());
        }

        



        // GET: Pdfs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pdf = await _context.Pdfs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pdf == null)
            {
                return NotFound();
            }

            return View(pdf);
        }

        // GET: Pdfs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pdfs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Create([Bind("Id,Name,ResimDosyasi,ResimYolu")] Pdf pdf)
        {
            

            if (ModelState.IsValid)
            {
                _context.Add(pdf);

                string resimler = Path.Combine(_environment.WebRootPath, "resimler");
                if (pdf.ResimDosyasi.Length > 0)
                {
                    using (var fileStream = new FileStream(Path.Combine(resimler, pdf.ResimDosyasi.FileName), FileMode.Create))
                    {
                        
                        await pdf.ResimDosyasi.CopyToAsync(fileStream);
                        
                        
                    }
                }
                pdf.ResimYolu = pdf.ResimDosyasi.FileName;



                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pdf);
        }

        


        // GET: Pdfs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pdf = await _context.Pdfs.FindAsync(id);
            if (pdf == null)
            {
                return NotFound();
            }
            return View(pdf);
        }

        // POST: Pdfs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Pdf pdf)
        {
            if (id != pdf.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pdf);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PdfExists(pdf.Id))
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
            return View(pdf);
        }

        // GET: Pdfs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pdf = await _context.Pdfs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pdf == null)
            {
                return NotFound();
            }

            return View(pdf);
        }

        // POST: Pdfs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pdf = await _context.Pdfs.FindAsync(id);
            _context.Pdfs.Remove(pdf);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PdfExists(int id)
        {
            return _context.Pdfs.Any(e => e.Id == id);
        }
    }
}
