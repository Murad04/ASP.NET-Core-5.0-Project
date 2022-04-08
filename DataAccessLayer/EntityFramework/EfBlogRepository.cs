using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using var c = new Context();
            return c.Blogs.Include(x => x.category).ToList();
        }

        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            using var c = new Context();
            return c.Blogs.Include(x => x.category).Where(x => x.WriterID == id).ToList();
        }

        public void LikeBlog(int id)
        {
            using var c = new Context();
            c.Blogs.Where(x => x.BlogID == id).FirstOrDefault().BlogID += 1;
        }
    }
}
