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
    public class WhatWeDoManager : IWhatWeDoService
    {
        private readonly IWhatWeDoDal _whatWeDoDal;

        public WhatWeDoManager(IWhatWeDoDal whatWeDoDal)
        {
            _whatWeDoDal = whatWeDoDal;
        }

        public void TAdd(WhatWeDo t)
        {
            _whatWeDoDal.Add(t);
        }

        public void TDelete(WhatWeDo t)
        {
            _whatWeDoDal.Delete(t);
        }

        public WhatWeDo TGetById(int id)
        {
            return _whatWeDoDal.GetById(id);
        }

        public List<WhatWeDo> TGetList()
        {
            return _whatWeDoDal.GetList();
        }

        public void TUpdate(WhatWeDo t)
        {
            _whatWeDoDal.Update(t);
        }
    }
}
