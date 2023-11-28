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
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public void TAdd(Team t)
        {
            _teamDal.Add(t);
        }

        public void TDelete(Team t)
        {
            _teamDal.Delete(t);
        }

        public Team TGetById(int id)
        {
            return _teamDal.GetById(id);
        }

        public List<Team> TGetList()
        {
            return _teamDal.GetList();
        }

        public void TUpdate(Team t)
        {
            _teamDal.Update(t);
        }
    }
}
