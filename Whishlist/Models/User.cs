﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wishlist.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        public string Name { get; set; }

        //[Required]
        public string Password{ get; set; }
    }
}