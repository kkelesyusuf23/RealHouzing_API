using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class ExpertManager : IExpertService
    {
        private readonly IExpertDal _expertDal;

        public ExpertManager(IExpertDal expertDal)
        {
            _expertDal = expertDal;
        }

        public void TAdd(Expert t)
        {
            _expertDal.Add(t);
        }

        public void TDelete(Expert t)
        {
            _expertDal.Delete(t);
        }

        public Expert TGetById(int id)
        {
            return _expertDal.GetById(id);
        }

        public List<Expert> TGetList()
        {
            return _expertDal.GetList();
        }

        public void TUpdate(Expert t)
        {
            _expertDal.Update(t);
        }
    }
}
