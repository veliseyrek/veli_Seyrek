using Cozum.Rapor.Data.Abstract;
using Cozum.Rapor.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cozum.Rapor.Data.Concrete
{
    public class EfCoreNsPersonelRepository : EfCoreGenericRepository<NsPersonel, COZUMREPORTContext>, INsPersonelRepository
    {

        //select a.PERSONEL_NO, a.ADISOYADI, b.NUM, b.TUR, b.VARSAYILAN, b.SUBE, c.PROF_PIC from NS_PERSONEL a left join RPR_DIRECTORY b on(a.PERSONEL_NO = b.PERSONEL_NO) left join RPR_PROFPIC c on(a.PERSONEL_NO = c.PERSONEL_NO) WHERE A.AKTIF = 'E'
        public List<NsPersonel> GetAllPersonel()
        {
            using (var context = new COZUMREPORTContext())
            {
                var personel = context.NsPersonels
                                .Where(a => a.PersonelNo > 0)
                                .OrderByDescending(a => a.Adisoyadi)
                                .ThenBy(a => a.PersonelNo);
                //var personel = from nsPersonel in context.NsPersonels
                //                where nsPersonel.PersonelNo >400
                //                orderby nsPersonel.Adisoyadi
                //                select nsPersonel;

                    return personel.ToList();
            }
        }
        
    }
} 
