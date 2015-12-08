using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog_yeni.Models
{
    public class post
    {

        public int Id { get; set; }

        public string baslik { get; set; }

        public string altBaslik { get; set; }

        public string icerik { get; set; }

        public string tarih { get; set; }

        public string resim { get; set; }

        public virtual editor editors { get; set; }
    }
}