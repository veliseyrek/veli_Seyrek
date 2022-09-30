using Cozum.Rapor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cozum.Rapor.Business.Abstract
{
   public interface INsPersonelService
    {
        NsPersonel GetById(int id);
        List<NsPersonel> GetAll();
        void Create(NsPersonel entity);
        void Update(NsPersonel entity);
        void Delete(NsPersonel entity);
        List<NsPersonel> GetAllPersonel();
    }
}
