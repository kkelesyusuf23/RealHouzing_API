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
    public class QuestionManager : IQuestionService
    {
        private readonly IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public void TAdd(Question t)
        {
            _questionDal.Add(t);
        }

        public void TDelete(Question t)
        {
            _questionDal.Delete(t);
        }

        public Question TGetById(int id)
        {
            return _questionDal.GetById(id);
        }

        public List<Question> TGetList()
        {
            return _questionDal.GetList();
        }

        public void TUpdate(Question t)
        {
            _questionDal.Update(t);
        }
    }
}
