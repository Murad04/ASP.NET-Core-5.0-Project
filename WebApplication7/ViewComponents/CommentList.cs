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
                    CommentUserName="M"
                },
                new UserComment
                {
                    ID=2,
                    CommentUserName="N"
                },
                new UserComment
                {
                    ID=3,
                    CommentUserName="S"
                }
            };
            return View(commentvalues);
        }
    }
}
