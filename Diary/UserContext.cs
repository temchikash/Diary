using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;


namespace Diary
{
    internal class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext() : base("DefaultConnection")
        {
        }
    }
}
