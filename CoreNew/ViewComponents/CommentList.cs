using CoreNew.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreNew.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Zehra"
                },
                new UserComment
                {
                    ID=2,
                    UserName="Bulut"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Büşra"
                },

            };
            return View(commentvalues);
        }


    }
}
