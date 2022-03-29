using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMessage2Dal:IGenericDal<Message2>
    {
        List<Message2> GetInboxListMessageByWriter(int id);
        List<Message2> GetSendBoxListMessageByWriter(int id);
        List<Message2> GetWorkMailListByWriter(int id);
        List<Message2> GetDocumentsMailListByWriter(int id);
        List<Message2> GetImportantMailListByWriter(int id);
        List<Message2> GetPromotionMailListByWriter(int id);
        List<Message2> GetDemandMailListByWriter(int id);
        void MarkAsImportant(int id);
        void MarkAsNotImportant(int id);
        void MarkAsRead(int id);
    }
}
