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
    public class ContactInfoManager : IContactInfoService
    {
        private readonly IContactInfoDal _contactInfoDal;

        public ContactInfoManager(IContactInfoDal contactInfoDal)
        {
            _contactInfoDal = contactInfoDal;
        }

        public void TAdd(ContactInfo t)
        {
            _contactInfoDal.Add(t);
        }

        public void TDelete(ContactInfo t)
        {
            _contactInfoDal.Delete(t);
        }

        public ContactInfo TGetById(int id)
        {
            return _contactInfoDal.GetById(id);
        }

        public List<ContactInfo> TGetList()
        {
            return _contactInfoDal.GetList();
        }

        public void TUpdate(ContactInfo t)
        {
            _contactInfoDal.Update(t);
        }
    }
}
