﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        public int AboutID { get; set; }

        public string Header { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }
    }
}
