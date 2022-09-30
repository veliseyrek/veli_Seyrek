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
    public class NsPersonelManager : INsPersonelService
    {
        private INsPersonelRepository _nsPersonelRepository;

        public NsPersonelManager(INsPersonelRepository nsPersonelRepository)
        {
            _nsPersonelRepository = nsPersonelRepository;
        }

        public void Create(NsPersonel entity)
        {
            _nsPersonelRepository.Create(entity);
        }

        public void Delete(NsPersonel entity)
        {
            _nsPersonelRepository.Delete(entity);
        }

        public List<NsPersonel> GetAll()
        {
            return _nsPersonelRepository.GetAll();
        }

        public List<NsPersonel> GetAllPersonel()
        {
            return _nsPersonelRepository.GetAllPersonel();
        }

        public NsPersonel GetById(int id)
        {
            return _nsPersonelRepository.GetById(id);
        }

        public void Update(NsPersonel entity)
        {
            _nsPersonelRepository.Update(entity);
        }
    }
}
