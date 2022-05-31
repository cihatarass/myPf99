using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int PortfolioID { get; set; }

        public int Name { get; set; }

        public int ImageURL { get; set; }
    }
}
