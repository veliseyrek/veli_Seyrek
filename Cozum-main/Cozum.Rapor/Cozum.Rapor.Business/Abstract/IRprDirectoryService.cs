using Cozum.Rapor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cozum.Rapor.Business.Abstract
{
   public interface IRprDirectoryService 
    {
        RprDirectory GetById(int id);
        RprDirectory GetSubeByPersonelNo(int personelNo);
        List<RprDirectory> GetAll();
        void Create(RprDirectory entity);
        void Update(RprDirectory entity);
        void Delete(RprDirectory entity);
    }
}
