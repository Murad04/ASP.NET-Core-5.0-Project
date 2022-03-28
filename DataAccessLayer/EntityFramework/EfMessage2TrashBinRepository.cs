using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessage2TrashBinRepository:GenericRepository<Message2TrashBin>,IMessage2TrashBinDal
    {
        public List<Message2TrashBin> GetListByID(int id)
        {
            using var c = new Context();
            return c.Message2TrashBins.Include(x => x.SenderUser).Where(x => x.Message_Receiver == id).ToList();
        }
    }
}
