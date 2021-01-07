﻿using System.Collections.Generic;

namespace InfoRioAPI.Repositories.Generics
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
