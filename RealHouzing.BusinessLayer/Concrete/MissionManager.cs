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
    public class MissionManager : IMissionService
    {
        private readonly IMissionDal _missionDal;

        public MissionManager(IMissionDal missionDal)
        {
            _missionDal = missionDal;
        }

        public void TAdd(Mission t)
        {
            _missionDal.Add(t);
        }

        public void TDelete(Mission t)
        {
            _missionDal.Delete(t);
        }

        public Mission TGetById(int id)
        {
            return _missionDal.GetById(id);
        }

        public List<Mission> TGetList()
        {
            return _missionDal.GetList();
        }

        public void TUpdate(Mission t)
        {
            _missionDal.Update(t);
        }
    }
}
