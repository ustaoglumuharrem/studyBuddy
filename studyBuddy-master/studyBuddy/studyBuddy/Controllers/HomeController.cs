using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using studyBuddy.Data;
using studyBuddy.Models;
using studyBuddy.ViewModel;

namespace studyBuddy.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Search()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["TermId"] = new SelectList(_context.Terms, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(SearchViewModel searchModel)
        {


            IQueryable<Pdf> pdfs = _context.Pdfs.AsQueryable();

            if (!String.IsNullOrWhiteSpace(searchModel.SearchText))
            {
               
                    pdfs = pdfs.Where(b => b.Name.Contains(searchModel.SearchText) || b.ResimYolu.Contains(searchModel.SearchText));
                
            }

            if (searchModel.CategoryId.HasValue)
            {
                pdfs = pdfs.Where(b => b.CategoryId == searchModel.CategoryId.Value);
            }

            if (searchModel.TermId.HasValue)
            {
                pdfs = pdfs.Where(b => b.TermId == searchModel.TermId.Value);
            }


            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", searchModel.CategoryId);
            ViewData["TermId"] = new SelectList(_context.Terms, "Id", "Name", searchModel.TermId);

            searchModel.Results = await pdfs.ToListAsync();
            return View(searchModel);
        }




    }
}
