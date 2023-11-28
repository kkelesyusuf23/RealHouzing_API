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
    public class BuyingManager : IBuyingService
    {
        private readonly IBuyingDal _buyingDal;

        public BuyingManager(IBuyingDal buyingDal)
        {
            _buyingDal = buyingDal;
        }

        public void TAdd(Buying t)
        {
            _buyingDal.Add(t);
        }

        public void TDelete(Buying t)
        {
            _buyingDal.Delete(t);
        }

        public Buying TGetById(int id)
        {
            return _buyingDal.GetById(id);
        }

        public List<Buying> TGetList()
        {
            return _buyingDal.GetList();
        }

        public void TUpdate(Buying t)
        {
            _buyingDal.Update(t);
        }
    }
}
