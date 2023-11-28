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
    public class TourManager : ITourService
    {
        private readonly ITourDal _tourDal;

        public TourManager(ITourDal tourDal)
        {
            _tourDal = tourDal;
        }

        public void TAdd(Tour t)
        {
            _tourDal.Add(t);
        }

        public void TDelete(Tour t)
        {
            _tourDal.Delete(t);
        }

        public Tour TGetById(int id)
        {
            return _tourDal.GetById(id);
        }

        public List<Tour> TGetList()
        {
            return _tourDal.GetList();
        }

        public void TUpdate(Tour t)
        {
            _tourDal.Update(t);
        }
    }
}
