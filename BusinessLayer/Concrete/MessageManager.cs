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
    public class MessageManager : IMessageService
    {
        IMessageDal _messagedal;

        public MessageManager(IMessageDal messagedal)
        {
            _messagedal = messagedal;
        }

        public void AddMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public void AddMessage(Message2 message)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            return _messagedal.GetListAll();
        }

        public List<Message> GetListByID(int id)
        {
            return _messagedal.GetListAll(m => m.Message_Receiver == id);
        }

        List<Message2> IMessageService.GetList()
        {
            throw new NotImplementedException();
        }

        List<Message2> IMessageService.GetListByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
