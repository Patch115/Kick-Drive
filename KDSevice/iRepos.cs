using System;
using System.Collections.Generic;
using System.ComponentModel;
using KDControl;
using KDSevice;

namespace KDSevice
{
    public interface IRepository<T> where T : EntityBase
    {
        public IEnumerable<T> GetAll();
        public T Get(int id);
        public int Insert(T obj);
        public void Update(T obj);
        public void Delete(T obj);
    }
}
