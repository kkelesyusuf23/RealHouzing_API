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
    public class ProgressManager : IProgressService
    {
        private readonly IProgressDal _progressDal;

        public ProgressManager(IProgressDal progressDal)
        {
            _progressDal = progressDal;
        }

        public void TAdd(Progress t)
        {
            _progressDal.Add(t);
        }

        public void TDelete(Progress t)
        {
            _progressDal.Delete(t);
        }

        public Progress TGetById(int id)
        {
            return _progressDal.GetById(id);
        }

        public List<Progress> TGetList()
        {
            return _progressDal.GetList();
        }

        public void TUpdate(Progress t)
        {
            _progressDal.Update(t);
        }
    }
}
