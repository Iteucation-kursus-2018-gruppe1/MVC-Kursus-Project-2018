using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Wishlist.Models
{
    public class UserInitializer : DropCreateDatabaseAlways<UserDB>
    {
        protected override void Seed(UserDB context)
            {
                base.Seed(context);

            var Users = new List<User>
            {
                new User
                {
                    Name="Poul",
                    Password="Password1"
                },
                new User
                {
                    Name="Dag",
                    Password="Password1"
                },
                new User
                {
                    Name="Mette",
                    Password="Password1"
                },
                new User
                {
                    Name="Gert",
                    Password="Password1"
                },
                new User
                {
                    Name="Janus",
                    Password="Password1"
                }
            };
                Users.ForEach(w => context.users.Add(w));
                context.SaveChanges();

        }

    }
    
}