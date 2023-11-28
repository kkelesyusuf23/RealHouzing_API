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
    public class CommercialManager : ICommercialService
    {
        private readonly ICommercialDal _commercialDal;

        public CommercialManager(ICommercialDal commercialDal)
        {
            _commercialDal = commercialDal;
        }

        public void TAdd(Commercial t)
        {
            _commercialDal.Add(t);
        }

        public void TDelete(Commercial t)
        {
            _commercialDal.Delete(t);
        }

        public Commercial TGetById(int id)
        {
            return _commercialDal.GetById(id);
        }

        public List<Commercial> TGetList()
        {
            return _commercialDal.GetList();
        }

        public void TUpdate(Commercial t)
        {
            _commercialDal.Update(t);
        }
    }
}
