﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGeneric<T> where T : class
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);

        List<T> ListAll();

        T GetById(int id);

		List<T> ListAll(Expression<Func<T,bool>>filter);
	}   
}
