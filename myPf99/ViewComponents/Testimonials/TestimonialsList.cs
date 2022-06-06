using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myPf99.ViewComponents.Testimonials
{
    public class TestimonialsList:ViewComponent
    {
        TestimonialsManager testimonialsManager = new TestimonialsManager(new EfTestimonialsDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonialsManager.TGetList();
            return View(values);
        }
    }
}
