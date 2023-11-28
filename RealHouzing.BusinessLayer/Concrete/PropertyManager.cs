
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
	public class PropertyManager:IPropertyService
	{
		private readonly IPropertyDal _propertyDal;

		public PropertyManager(IPropertyDal propertyDal)
		{
			_propertyDal = propertyDal;
		}

		public void TAdd(Property t)
		{
			_propertyDal.Add(t);
		}


		public void TDelete(Property t)
		{
			_propertyDal.Delete(t);
		}


		public Property TGetById(int id)
		{
			return _propertyDal.GetById(id);
		}

		public List<Property> TGetList()
		{
			return _propertyDal.GetList();
		}

		public void TUpdate(Property t)
		{
			_propertyDal.Update(t);
		}

	}
}
