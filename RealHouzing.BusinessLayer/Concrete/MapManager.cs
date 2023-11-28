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
    public class MapManager : IMapService
    {
        private readonly IMapDal _mapDal;

        public MapManager(IMapDal mapDal)
        {
            _mapDal = mapDal;
        }

        public void TAdd(Map t)
        {
            _mapDal.Add(t);
        }

        public void TDelete(Map t)
        {
            _mapDal.Delete(t);
        }

        public Map TGetById(int id)
        {
            return _mapDal.GetById(id);
        }

        public List<Map> TGetList()
        {
            return _mapDal.GetList();
        }

        public void TUpdate(Map t)
        {
            _mapDal.Update(t);
        }
    }
}
