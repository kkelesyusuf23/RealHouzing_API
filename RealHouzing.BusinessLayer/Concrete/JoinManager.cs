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
    public class JoinManager : IJoinService
    {
        private readonly IJoinDal _joinDal;

        public JoinManager(IJoinDal joinDal)
        {
            _joinDal = joinDal;
        }

        public void TAdd(Join t)
        {
            _joinDal.Add(t);
        }

        public void TDelete(Join t)
        {
            _joinDal.Delete(t);
        }

        public Join TGetById(int id)
        {
            return _joinDal.GetById(id);
        }

        public List<Join> TGetList()
        {
            return _joinDal.GetList();
        }

        public void TUpdate(Join t)
        {
            _joinDal.Update(t);
        }
    }
}
