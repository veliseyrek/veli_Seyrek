using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EF_CodeFirst.Controllers
{
    // [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly Library6Context _context;

        public BookController(Library6Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Books.ToList());
        }

        public IActionResult Create(string id)
        {
            var kitaplar = _context.Books.Find(id);
            ViewData["Category"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["Author"] = new SelectList(_context.Authors, "AuthorId", "AuthorName");
            ViewData["Publisher"] = new SelectList(_context.Publishers, "PublisherId", "PublisherName");
            return View(kitaplar);
        }

        [HttpPost]
        public IActionResult Create(Book kitaplar)
        {
            _context.Add(kitaplar);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var kitaplar = _context.Books.Find(id);
            ViewData["Category"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["Author"] = new SelectList(_context.Authors, "AuthorId", "AuthorName");
            ViewData["Publisher"] = new SelectList(_context.Publishers, "PublisherId", "PublisherName");
            return View(kitaplar);
        }

        [HttpPost]
        public IActionResult Edit(Book kitaplar)
        {
            if (ModelState.IsValid)
            {
                _context.Update(kitaplar);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kitaplar);
        }
        public IActionResult Delete(int id)
        {
            var kitap = _context.Books.Find(id);
            return View(kitap);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var kitap = _context.Books.Find(id);
            kitap.IsDeleted = true;
            _context.Update(kitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var kitap = _context.Books
                    .Include(k => k.Category)
                    .Include(k => k.Author)
                    .Include(k => k.Publisher)
                     .First(sk => sk.BookId == id);
            return View(kitap);
        }
    }
}