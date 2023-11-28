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
    public class PlanManager : IPlanService
    {
        private readonly IPlanDal _planDal;

        public PlanManager(IPlanDal planDal)
        {
            _planDal = planDal;
        }

        public void TAdd(Plan t)
        {
            _planDal.Add(t);
        }

        public void TDelete(Plan t)
        {
            _planDal.Delete(t);
        }

        public Plan TGetById(int id)
        {
            return _planDal.GetById(id);
        }

        public List<Plan> TGetList()
        {
            return _planDal.GetList();
        }

        public void TUpdate(Plan t)
        {
            _planDal.Update(t);
        }
    }
}
