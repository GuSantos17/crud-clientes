using System;
using System.Collections.Generic;
using System.Linq;
using TesteBRQ.CrudUsers.Domain;
using TesteBRQ.CrudUsers.Infra.Context;

namespace TesteBRQ.CrudUsers.Infra.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly CrudUsersContext _context;

        public RepositoryBase(CrudUsersContext context)
        {
            _context = context;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Add(T item)
        {
            try
            {
                _context.Set<T>().Add(item);

            }
            catch (Exception)
            {
                throw;
            }
        }
        public T FindById(params object[] key)
        {
            return _context.Set<T>().Find(key);
        }
        public void Remove(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(T item)
        {
            try
            {
                _context.Set<T>().Update(item);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
