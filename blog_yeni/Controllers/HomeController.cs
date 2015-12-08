using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog_yeni.DAL;
using blog_yeni.Models;
using System.Data.Entity;


namespace blog_yeni.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        YeniBlog db = new YeniBlog();
        public ActionResult Index()
        {
            ViewBag.resim = "manzara-1.jpg";
            ViewBag.baslik = "Anasayfa";
            ViewBag.altbaslik = "En güncel teknoloji bilgilerine hoşgeldiniz";
            List<post> m = db.post.OrderByDescending(a => a.tarih).Take(3).ToList();
            return View(m);

        }
        public ActionResult hakkimizda()
        {
            ViewBag.resim = "manzara-2.jpg";
            ViewBag.baslik = "Hakkımızda";
            List<hakkimizda> h = db.hk.ToList();
            ViewBag.altbaslik = "Bizi tanıyın";
            return View(h);
        }

        public ActionResult iletisim()
        {
            ViewBag.resim = "manzara-4.jpg";
            ViewBag.baslik = "İletişim";
            ViewBag.altbaslik = "Bağlantı kurun";
            
            return View();
        }
        [HttpPost]
     
        public ActionResult iletisim(iletisim iltsm)
        {
            ViewBag.resim = "manzara-4.jpg";
            ViewBag.baslik = "İletişim";
            ViewBag.altbaslik = "Bağlantı kurun";
            db.Entry(iltsm).State = EntityState.Added;
            db.SaveChanges();
            TempData["notice"] = "Yorumunuz gönderildi";
            ModelState.Clear();
            return View();
        }

        public ActionResult tumyazilar()
        {
            ViewBag.resim = "eski.jpg";
            ViewBag.baslik = "Eski Yazılar";
            ViewBag.altbaslik = "Tüm postları görüntüleyin";
            List<post> tp = db.post.ToList();
            return View(tp);
        }
        
        public ActionResult posts(int id)
        {
            post postlar = db.post.Where(a => a.Id==id).FirstOrDefault();
            ViewBag.resim = postlar.resim;
            ViewBag.baslik = postlar.baslik;
            ViewBag.altbaslik = postlar.altBaslik;
            return View(postlar);
        }

    }
}
