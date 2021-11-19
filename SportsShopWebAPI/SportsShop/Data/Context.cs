using Microsoft.EntityFrameworkCore;
using SportsShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShop.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {
            
        }

        public  DbSet<Customer> Customer  { get; set; }
        public DbSet<Item> Item { get; set; }

        public DbSet<Order> Order { get; set; }
    }
}
