﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Wishlist.Models
{
    public class WishDB : DbContext
    {
        public DbSet<Wish> wishes { get; set; }
    }
}