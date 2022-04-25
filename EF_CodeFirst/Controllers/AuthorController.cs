using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    // [Route("[controller]")]
    public class AuthorController : Controller
    {
        private readonly Library6Context _context;

        public AuthorController(Library6Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Authors.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(Author author)
        {
            _context.Add(author);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
           var author = _context.Authors.Find(id);
            return View(author);
        }

         public IActionResult Edit(int id)
        {
            var author = _context.Authors.Find(id);
            return View(author);
        }
        [HttpPost]
        public IActionResult Edit(Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }
            _context.Update(author);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
         {
             var tur = _context.Authors.Find(id);
             return View(tur);
         }
         [HttpPost,ActionName("Delete")]
         public IActionResult DeleteConfirmed(int id)
         {
             var del = _context.Authors.Find(id);
             _context.Authors.Remove(del);
             _context.SaveChanges();
             return RedirectToAction("Index");
         }
        
    }
}