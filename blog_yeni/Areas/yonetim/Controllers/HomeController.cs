using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog_yeni.DAL;
using blog_yeni.Models;

namespace blog_yeni.Areas.yonetim.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /yonetim/Home/

        YeniBlog db = new YeniBlog();
        public ActionResult Index()
        {
            int t = db.iletisim.Count();
            ViewBag.sayi = t;
            return View();
        }
       

    }
}
