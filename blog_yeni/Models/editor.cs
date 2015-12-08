using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog_yeni.Models
{
    public class editor
    {
        public int Id { get; set; }

        public string name { get; set; }

        public string userName { get; set; }

        public string passWord { get; set; }

        public virtual ICollection<post> post { get; set; }
    }
}