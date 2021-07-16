using System.Collections.Generic;

namespace TesteBRQ.CrudUsers.Domain 
{ 
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T item);
        List<T> GetAll();
        T FindById(params object[] key);
        void Remove(T item);
        void Update(T item);
    }
}
