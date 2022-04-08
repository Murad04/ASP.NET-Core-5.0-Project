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
    public class EfAdminRepository : GenericRepository<Admin>, IAdminDal
    {
        public string GetadminRole(string username)
        {
            using var c = new Context();
            return c.Admins.Include(x => x.AdminUsername == username).Select(x => x.AdminRole).ToString();
        }

        public List<Admin> GetByIdData(int id)
        {
            using var c = new Context();
            return c.Admins.Where(x => x.AdminID == id).ToList();
        }

    }
}
