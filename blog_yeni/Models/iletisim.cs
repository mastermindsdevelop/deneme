using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace blog_yeni.Models
{
    public class iletisim
    {
        public int Id { get; set; }
        

        
        [Required]
        public string name { get; set; }

        [Required]
        public string emailAddress { get; set; }
          [Required]
        public string phoneNumber { get; set; }
          [Required]
        public string yorum { get; set; }


    }
}