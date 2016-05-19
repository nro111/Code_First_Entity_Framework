using EFTest.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Context
{
    public class MyContext : DbContext
    {
        public virtual DbSet<UserInfo> UserInformation { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserCredential> UserCredentials { get; set; }
    }
}
