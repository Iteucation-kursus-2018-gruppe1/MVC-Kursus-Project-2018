using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Wishlist.Models
{
    class WishInitializer : DropCreateDatabaseAlways<WishDB>
    {
        protected override void Seed(WishDB context)
        {
            base.Seed(context);

            var Wishes = new List<Wish>
            {
                new Wish
                {
                    //UserID = 0,
                    Title ="String",
                    Description = "String for nitting",
                    Status = false
                }
            };
            Wishes.ForEach(w => context.wishes.Add(w));
            context.SaveChanges();
        }
    }
}