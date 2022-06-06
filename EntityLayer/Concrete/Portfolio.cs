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

        public string Name { get; set; }

        public string ImageURL { get; set; }

        public string Description { get; set; }

        public string Links { get; set; }
    }
}
