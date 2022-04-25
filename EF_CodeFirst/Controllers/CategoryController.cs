using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EF_CodeFirst.Models;

namespace Controllers
{
    // [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly Library6Context _context;

        public CategoryController(Library6Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }
        public IActionResult Details(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }
            _context.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

         public IActionResult Delete(int id)
         {
             var tur = _context.Categories.Find(id);
             return View(tur);
         }
         [HttpPost,ActionName("Delete")]
         public IActionResult DeleteConfirmed(int id)
         {
             var del = _context.Categories.Find(id);
             _context.Categories.Remove(del);
             _context.SaveChanges();
             return RedirectToAction("Index");
         }


    }
}