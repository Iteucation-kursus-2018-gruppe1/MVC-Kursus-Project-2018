using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Whishlist.Models
{
    public class UserDB : DbContext
    {
        public DbSet<User> users { get; set; }
    }
}