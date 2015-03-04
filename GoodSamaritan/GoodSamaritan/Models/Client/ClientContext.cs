using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class ClientContext:DbContext
    {
        public ClientContext() : base("DefaultConnection")
        { Database.SetInitializer(new DropCreateDatabaseAlways<ClientContext>()); }
        public DbSet<Client> Clients{get; set;}

        public DbSet<User> Users {get; set;}

        


    }
}