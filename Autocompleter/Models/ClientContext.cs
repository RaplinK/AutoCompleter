using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Autocompleter.Models
{
    public class ClientsContext : DbContext
    {
        public DbSet<People> People { get; set; }

        public ClientsContext() : base("Clients")
        {
            if (!Database.Exists())
                Database.Create();

            SaveChanges();
        }


    }
}
