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
    public class RprDirectoryManager : IRprDirectoryService
    {
        private IRprDirectoryRepository _rprDirectoryRepository;

        public RprDirectoryManager(IRprDirectoryRepository rprDirectoryRepository)
        {
            _rprDirectoryRepository = rprDirectoryRepository;
        }

        public void Create(RprDirectory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(RprDirectory entity)
        {
            throw new NotImplementedException();
        }

        public List<RprDirectory> GetAll()
        {
            throw new NotImplementedException();
        }

        public RprDirectory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public RprDirectory GetSubeByPersonelNo(int personelNo)
        {
            return _rprDirectoryRepository.GetSubeByPersonelNo(personelNo);
        }

        public void Update(RprDirectory entity)
        {
            throw new NotImplementedException();
        }
    }
}
