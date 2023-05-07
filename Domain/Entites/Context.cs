using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }   
        public DbSet<Cart> Carts { get; set; }
    }
}
