using Cozum.Rapor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cozum.Rapor.Data.Abstract
{
    public interface INsPersonelRepository : IRepository<NsPersonel>
    {
        List<NsPersonel> GetAllPersonel();
    }
}
