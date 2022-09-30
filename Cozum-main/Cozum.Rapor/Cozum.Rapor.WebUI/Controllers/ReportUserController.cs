using Cozum.Rapor.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Cozum.Rapor.Entities;

namespace Cozum.Rapor.WebUI.Controllers
{
   
    public class ReportUserController : Controller
    {
        private IReportUserService _reportUserService;

        public ReportUserController(IReportUserService reportUserService)
        {
            _reportUserService = reportUserService;
        }  
        public IActionResult Index()
        {
            var values = _reportUserService.GetAll();
            return View(values);
        }
        public JsonResult ListRapor()
        {
            var values = _reportUserService.GetAll();
            return Json(new { data=values});
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RprUser rprUser)
        {
            RprUser rpr = new()
            {
                Username=rprUser.Username,
                Password = rprUser.Password,
                Name = rprUser.Name,
                Lastname = rprUser.Lastname,
                EMail=rprUser.EMail,
                Departmant = rprUser.Departmant
            };
            _reportUserService.Create(rpr);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var entity = _reportUserService.GetById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(RprUser rpr)
        {
            var entity = _reportUserService.GetById(rpr.Id);

            entity.Username = rpr.Username;
            entity.Name = rpr.Name;
            entity.Lastname = rpr.Lastname;
            entity.Password = rpr.Password;
            entity.EMail = rpr.EMail;
            entity.Departmant = rpr.Departmant;

            _reportUserService.Update(entity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var entity = _reportUserService.GetById(id);
            _reportUserService.Delete(entity);
            return RedirectToAction("Index");
        }

       
    }
}
