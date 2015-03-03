using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Users
{
    public class ClientContext:DbContext
    {
        public ClientContext() : base("DefaultConnection")
        {}
        public DbSet<Client> Clients{get; set;}

        public DbSet<User> Users {get; set;}

        


    }
}