﻿using DataAccessLayer.Abstract;
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
    public class EfMessage2Repository : GenericRepository<Message2>, IMessage2Dal
    {
        public List<Message2> GetInboxListMessageByWriter(int id)
        {
            using var c = new Context();
            return c.Messages2s.Include(x => x.SenderUser).Where(x => x.Message_Receiver == id).ToList();
        }

        public List<Message2> GetSendBoxListMessageByWriter(int id)
        {
            using var c = new Context();
            var data = c.Messages2s.Include(x => x.ReceiverUser).Where(x => x.Message_Sender == id).ToList();
            return data;
        }
    }
}
