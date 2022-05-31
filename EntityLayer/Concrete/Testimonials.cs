using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Testimonials
    {
        [Key]
        public int TestimonialsID { get; set; }

        public string ClientName { get; set; }

        public string Company { get; set; }

        public string Comment { get; set; }

        public string ImageURL { get; set; }
    }
}
