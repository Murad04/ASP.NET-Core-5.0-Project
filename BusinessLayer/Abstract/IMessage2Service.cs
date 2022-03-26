using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessage2Service:IGenericService<Message2>
    {
        List<Message2> GetInboxListByWriter(int id);
        List<Message2> GetSendboxListByWriter(int id);
        List<Message2> GetDocumentsMailListByWriter(int id);
        List<Message2> GetImportantMailListByWriter(int id);
        List<Message2> GetPromotionMailListByWriter(int id);
        List<Message2> GetDemandMailListByWriter(int id);
    }
}
