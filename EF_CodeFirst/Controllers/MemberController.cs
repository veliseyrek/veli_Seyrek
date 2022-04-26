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
    public class MemberController : Controller
    {
         private readonly Library6Context _context;

        public MemberController(Library6Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Members.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Member member)
        {
            _context.Add(member);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Details(int id)
        {
            var member = _context.Members.Find(id);
            return View(member);
        }

         public IActionResult Edit(int id)
        {
            var member = _context.Members.Find(id);
            return View(member);
        }
        [HttpPost]
        public IActionResult Edit(Member member)
        {
            if (!ModelState.IsValid)
            {
                return View(member);
            }
            _context.Update(member);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
         public IActionResult Delete(int id)
         {
             var tur = _context.Members.Find(id);
             return View(tur);
         }
         [HttpPost,ActionName("Delete")]
         public IActionResult DeleteConfirmed(int id)
         {
             var del = _context.Members.Find(id);
             _context.Members.Remove(del);
             _context.SaveChanges();
             return RedirectToAction("Index");
         }
    }
}