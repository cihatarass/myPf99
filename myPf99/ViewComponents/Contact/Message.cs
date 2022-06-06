using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myPf99.ViewComponents.Contact
{
    public class Message:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
