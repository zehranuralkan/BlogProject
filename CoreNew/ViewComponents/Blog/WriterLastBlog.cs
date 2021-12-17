using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreNew.ViewComponents.Blog
{
    public class WriterLastBlog:ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());  
        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListByWriter(2);
            return View(values);
        }
    }
}
