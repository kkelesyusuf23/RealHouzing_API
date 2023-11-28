using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLayer.EntityFramework;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.BusinessLayer.Concrete
{
    public class OptionManager : IOptionService
    {
        private readonly IOptionDal _optionDal;

        public OptionManager(IOptionDal optionDal)
        {
            _optionDal = optionDal;
        }

        public void TAdd(Option t)
        {
            _optionDal.Add(t);    
        }

        public void TDelete(Option t)
        {
            _optionDal.Delete(t);
        }

        public Option TGetById(int id)
        {
            return _optionDal.GetById(id);
        }

        public List<Option> TGetList()
        {
            return _optionDal.GetList();
        }

        public void TUpdate(Option t)
        {
            _optionDal.Update(t);
        }
    }
}
