using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DZ3
{
    public class MyContext : DbContext
    {
        public MyContext() : base("dataConnectionString")
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}