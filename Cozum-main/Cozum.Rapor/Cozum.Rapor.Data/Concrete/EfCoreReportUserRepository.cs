using Cozum.Rapor.Data.Abstract;
using Cozum.Rapor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cozum.Rapor.Data.Concrete
{
    public class EfCoreReportUserRepository : EfCoreGenericRepository<RprUser , COZUMREPORTContext>, IReportUserRepository
    {

    }
}
