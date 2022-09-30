using Cozum.Rapor.Data.Abstract;
using Cozum.Rapor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cozum.Rapor.Data.Concrete
{
    public class EfCoreRprDirectoryRepository : EfCoreGenericRepository<RprDirectory, COZUMREPORTContext>, IRprDirectoryRepository
    {
        public RprDirectory GetSubeByPersonelNo(int personelNo)
        {
            using (var context = new COZUMREPORTContext())
            {
                var _id = Convert.ToInt32(personelNo);
                return context.Set<RprDirectory>().FirstOrDefault(i=>i.PersonelNo==_id);
            } 
        }
    }
}
