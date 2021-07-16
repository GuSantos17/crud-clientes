using System;
using System.Collections.Generic;
using System.Text;

namespace TesteBRQ.CrudUsers.Infra.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
        void Roolback();
    }
}
