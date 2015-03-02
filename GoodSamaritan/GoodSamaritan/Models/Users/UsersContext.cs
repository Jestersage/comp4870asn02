using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Users
{
    public class UsersContext:DbContext
    {
        public UsersContext() : base("DefaultConnection")
        {
        }


    }
}