using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrdersAPI.Data
{
    public class OrdersDbContext : DbContext
    {
        public OrdersDbContext (DbContextOptions<OrdersDbContext> options)
            : base(options)
        {
        }

        public DbSet<Orders> Orders { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;

    }
}
