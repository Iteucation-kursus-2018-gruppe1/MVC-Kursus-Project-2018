using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Whishlist.Models
{
    public class Wish
    {
        public int WishID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public bool Status { get; set; }

    }
}