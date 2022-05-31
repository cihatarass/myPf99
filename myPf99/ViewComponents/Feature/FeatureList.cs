using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myPf99.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureManager FeatureManager = new FeatureManager(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            var values = FeatureManager.TGetList();
            return View(values);
        }
    }
}
