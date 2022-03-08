using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    CommentUserName="Murad"
                },
                new UserComment
                {
                    ID=2,
                    CommentUserName="Nicat"
                },
                new UserComment
                {
                    ID=3,
                    CommentUserName="Sadiq"
                }
            };
            return View(commentvalues);
        }
    }
}
