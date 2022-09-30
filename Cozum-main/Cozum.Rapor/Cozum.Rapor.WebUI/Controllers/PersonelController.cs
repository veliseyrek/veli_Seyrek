using Cozum.Rapor.Business.Abstract;
using Cozum.Rapor.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cozum.Rapor.Data;

namespace Cozum.Rapor.WebUI.Controllers
{
    public class PersonelController : Controller
    {
        private COZUMREPORTContext _context;
        private INsPersonelService _nsPersonelService;
        private IRprDirectoryService _rprDirectoryService;

        public PersonelController(COZUMREPORTContext context, INsPersonelService nsPersonelService, IRprDirectoryService rprDirectoryService)
        {
            _context = context;
            _nsPersonelService = nsPersonelService;
            _rprDirectoryService = rprDirectoryService;
        }

        public IActionResult Index()
        {
            var model = new List<PersonelModel>();
            var values = _nsPersonelService.GetAll();
            values.ForEach(s=>model.Add(new PersonelModel
            {
                PersonelNo = s.PersonelNo,
                AdiSoyadi = s.Adisoyadi,
                Num = _rprDirectoryService.GetSubeByPersonelNo(s.PersonelNo)?.Num,
                Tur = _rprDirectoryService.GetSubeByPersonelNo(s.PersonelNo)?.Tur,
                Varsayilan = _rprDirectoryService.GetSubeByPersonelNo(s.PersonelNo)?.Varsayilan,
                Sube = _rprDirectoryService.GetSubeByPersonelNo(s.PersonelNo)?.Sube
            }));
            return View(model);          
        }
    }
}
