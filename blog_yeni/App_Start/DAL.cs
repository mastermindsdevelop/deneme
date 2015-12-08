using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using blog_yeni.Models;


namespace blog_yeni.DAL
{
    public class YeniBlog:DbContext
    {
        public YeniBlog():base("YeniBlog")
        {

        }

        public DbSet<hakkimizda> hk { get;set; }

        public DbSet<editor> editor { get; set; }

        public DbSet<post> post { get; set; }

        public DbSet<iletisim> iletisim { get; set; }
    }
}