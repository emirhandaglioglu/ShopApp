﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataLayer.Abstract
{
    public interface IRepository<T> 
    {
        List<T> List();
        void Insert(T p);
        void Update(T p);
        void Delete(T p);
        List<T> List(Expression<Func<T, bool>> filter);//şartlı listeleme
        T Get(Expression<Func<T, bool>> filter);
    }
}
