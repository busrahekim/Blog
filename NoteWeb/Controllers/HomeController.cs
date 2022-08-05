using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NoteWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NoteWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NoteContext _context;


        public HomeController(ILogger<HomeController> logger, NoteContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Notes.Where(a => a.IsPublish).ToList();
            foreach (var note in list)
            {
                note.Author = _context.Authors.Find(note.AuthorId);
            }
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();  
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Post(int Id)
        {
            var note = _context.Notes.Find(Id);
            note.Author = _context.Authors.Find(note.AuthorId);
            return View(note);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
