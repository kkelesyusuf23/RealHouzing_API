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
    public class RegisterPropertyManager : IRegisterPropertyService
    {
        private readonly IRegisterPropertyDal _registerPropertyDal;

        public RegisterPropertyManager(IRegisterPropertyDal registerPropertyDal)
        {
            _registerPropertyDal = registerPropertyDal;
        }

        public void TAdd(RegisterProperty t)
        {
            _registerPropertyDal.Add(t);
        }

        public void TDelete(RegisterProperty t)
        {
            _registerPropertyDal.Delete (t);
        }

        public RegisterProperty TGetById(int id)
        {
            return _registerPropertyDal.GetById (id);   
        }

        public List<RegisterProperty> TGetList()
        {
            return _registerPropertyDal.GetList();
        }

        public void TUpdate(RegisterProperty t)
        {
            _registerPropertyDal.Update(t);
        }
    }
}
