using Cozum.Rapor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cozum.Rapor.Business.Abstract
{
   public interface IReportUserService
    {
        RprUser GetById(int id);
        List<RprUser> GetAll();
        void Create(RprUser entity);
        void Update(RprUser entity);
        void Delete(RprUser entity);
    }
}
