using System;
using System.Collections.Generic;
using System.Text;
using TesteBRQ.CrudUsers.Infra.Context;

namespace TesteBRQ.CrudUsers.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CrudUsersContext _context;

        public UnitOfWork(CrudUsersContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Roolback()
        {
        }
    }
}
