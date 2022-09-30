using Cozum.Rapor.Business.Abstract;
using Cozum.Rapor.Data.Abstract;
using Cozum.Rapor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cozum.Rapor.Business.Concrete
{
    public class ReportUserManager : IReportUserService
    {
        private IReportUserRepository _reportUserRepository;

        public ReportUserManager(IReportUserRepository reportUserRepository)
        {
            _reportUserRepository = reportUserRepository;
        }

        public void Create(RprUser entity)
        {
            _reportUserRepository.Create(entity);
        }

        public void Delete(RprUser entity)
        {
            _reportUserRepository.Delete(entity);
        }

        public List<RprUser> GetAll()
        {
           return _reportUserRepository.GetAll();
        }

        public RprUser GetById(int id)
        {
            return _reportUserRepository.GetById(id);
        }

        public void Update(RprUser entity)
        {
            _reportUserRepository.Update(entity);
        }
    }
}
