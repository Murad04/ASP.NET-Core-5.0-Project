using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessage2TrashBinService:IGenericService<Message2TrashBin>
    {
        void AddMessage(Message2TrashBin message);
        List<Message2TrashBin> GetListById(int id);
    }
}
