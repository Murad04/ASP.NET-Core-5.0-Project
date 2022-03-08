using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager:IAboutService
    {
        IAboutDal _dal;

        public AboutManager(IAboutDal dal)
        {
            _dal = dal;
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            return _dal.GetListAll();
        }

        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}
