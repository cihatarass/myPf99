﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EntityFramework
{
    public class EfSocialMediaDal: GenericRepository<SocialMedia>, ISocialMediaDal
    {
    }
}
