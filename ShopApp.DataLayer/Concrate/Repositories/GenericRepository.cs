﻿using ShopApp.DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataLayer.Concrate.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        ShopAppContext context = new ShopAppContext();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T p)
        {
            _object.Remove(p);
            context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public void Insert(T p)
        {
            _object.Add(p);
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            context.SaveChanges();
        }
    }
}