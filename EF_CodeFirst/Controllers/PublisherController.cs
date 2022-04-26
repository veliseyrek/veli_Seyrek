using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_CodeFirst.Controllers
{
    // [Route("[controller]")]
    public class PublisherController : Controller
    {
        private readonly Library6Context _context;

        public PublisherController(Library6Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Publishers.ToList());
        }

       public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Publisher publisher)
        {
            _context.Add(publisher);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
         public IActionResult Details(int id)
        {
            var publisher = _context.Publishers.Find(id);
            return View(publisher);
        }
         public IActionResult Edit(int id)
        {
            var publisher = _context.Publishers.Find(id);
            return View(publisher);
        }
        [HttpPost]
        public IActionResult Edit(Publisher publisher)
        {
            if (!ModelState.IsValid)
            {
                return View(publisher);
            }
            _context.Update(publisher);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
         {
             var tur = _context.Publishers.Find(id);
             return View(tur);
         }
         [HttpPost,ActionName("Delete")]
         public IActionResult DeleteConfirmed(int id)
         {
             var del = _context.Publishers.Find(id);
             _context.Publishers.Remove(del);
             _context.SaveChanges();
             return RedirectToAction("Index");
         }
    }
}