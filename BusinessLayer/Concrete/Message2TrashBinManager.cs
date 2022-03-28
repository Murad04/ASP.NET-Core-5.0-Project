using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Message2TrashBinManager : IMessage2TrashBinService
    {
        IMessage2TrashBinDal _message2TrashBinDal;

        public Message2TrashBinManager(IMessage2TrashBinDal message2TrashBinDal)
        {
            _message2TrashBinDal = message2TrashBinDal;
        }

        public void AddMessage(Message2TrashBin message)
        {
            _message2TrashBinDal.Insert(message);
        }

        public Message2TrashBin GetById(int id)
        {
            return _message2TrashBinDal.GetById(id);
        }

        public List<Message2TrashBin> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Message2TrashBin> GetListById(int id)
        {
            return _message2TrashBinDal.GetListByID(id);
        }

        public void TAdd(Message2TrashBin t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message2TrashBin t)
        {
            _message2TrashBinDal.Delete(t);
        }

        public void TUpdate(Message2TrashBin t)
        {
            throw new NotImplementedException();
        }
    }
}
