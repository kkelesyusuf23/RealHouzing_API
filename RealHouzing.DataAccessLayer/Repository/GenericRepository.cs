using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T t)
        {
            var context = new Context();
            context.Add(t);
            context.SaveChanges();
        }

        public void Delete(T t)
        {
            var context = new Context();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            var context = new Context();
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            var context = new Context();
            return context.Set<T>().ToList();
        }

        public void Update(T t)
        {
            var context = new Context();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
