using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteBRQ.CrudUsers.Domain.Models;

namespace TesteBRQ.CrudUsers.Infra.Context
{
    public class CrudUsersContext : DbContext
    {
        public CrudUsersContext(DbContextOptions<CrudUsersContext> options) : base(options)
        {

        }
        public CrudUsersContext()
        {

        }

        public DbSet<User> User { get; set; }
    }
}
