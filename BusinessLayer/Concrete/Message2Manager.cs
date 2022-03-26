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
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _message2Dal;

        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }

        public Message2 GetById(int id)
        {
            return _message2Dal.GetById(id);
        }
        public List<Message2> GetWorkMailListByWriter(int id)
        {
            return _message2Dal.GetWorkMailListByWriter(id);
        }
        public List<Message2> GetInboxListByWriter(int id)
        {
            return _message2Dal.GetInboxListMessageByWriter(id);
        }

        public List<Message2> GetList()
        {
            return _message2Dal.GetListAll();
        }

        public List<Message2> GetSendboxListByWriter(int id)
        {
            return _message2Dal.GetSendBoxListMessageByWriter(id);
        }

        public void TAdd(Message2 t)
        {
            _message2Dal.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetDocumentsMailListByWriter(int id)
        {
            return _message2Dal.GetDocumentsMailListByWriter(id);
        }

        public List<Message2> GetImportantMailListByWriter(int id)
        {
            return _message2Dal.GetImportantMailListByWriter(id);
        }

        public List<Message2> GetPromotionMailListByWriter(int id)
        {
            return _message2Dal.GetPromotionMailListByWriter(id);
        }

        public List<Message2> GetDemandMailListByWriter(int id)
        {
            return _message2Dal.GetDemandMailListByWriter(id);
        }
    }
}
