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
    public class NewsManager : INewsService
    {
        private readonly INewsDal _newsDal;

        public NewsManager(INewsDal newsDal)
        {
            _newsDal = newsDal;
        }

        public void TAdd(News t)
        {
            _newsDal.Add(t);
        }

        public void TDelete(News t)
        {
            _newsDal.Delete(t);
        }

        public News TGetById(int id)
        {
            return _newsDal.GetById(id);
        }

        public List<News> TGetList()
        {
            return _newsDal.GetList();
        }

        public void TUpdate(News t)
        {
            _newsDal.Update(t);
        }
    }
}
