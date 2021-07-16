using System;
using System.Collections.Generic;
using System.Text;
using TesteBRQ.CrudUsers.Domain;
using TesteBRQ.CrudUsers.Domain.Models;
using TesteBRQ.CrudUsers.Infra.Context;

namespace TesteBRQ.CrudUsers.Infra.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly CrudUsersContext _context;
        public UserRepository(CrudUsersContext context) : base(context)
        {
            _context = context;
        }
    }
}
