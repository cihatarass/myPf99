﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T: class
    {
        void Insert(T t);

        void Delete(T t);

        void Update(T t);

        List<T> GetAll();

        T GetByID(int id);

    }
}
