using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        void AddMessage(Message2 message);
        List<Message2> GetList();
        List<Message2> GetListByID(int id);
    }
}
