
using Cozum.Rapor.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Cozum.Rapor.Entities;

namespace Cozum.Rapor.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly COZUMREPORTContext _context;

        public HomeController(COZUMREPORTContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {         
            return View();
        }
        //[HttpGet]
        // public JsonResult ListaEmpleados()
        //{
        //    List<RprUser> liste = new List<RprUser>();
        //    var values = 
        //}

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
