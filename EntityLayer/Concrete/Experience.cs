﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int ExprerienceID { get; set; }

        public string Name { get; set; }

        public string Date { get; set; }

        public string ImageURL { get; set; }

        public string Description { get; set; }
    }
}
