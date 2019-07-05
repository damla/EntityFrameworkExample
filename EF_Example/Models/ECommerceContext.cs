using EF_Example.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Example.Models
{
    public class ECommerceContext: DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
