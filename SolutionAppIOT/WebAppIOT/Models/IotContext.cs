using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace WebAppIOT.Models
{
    public class IotContext : DbContext
    {
        public IotContext(DbContextOptions<IotContext> options)
            : base(options)
        { }

        public DbSet<Technicien> technicien { get; set; }
        public DbSet<System> system { get; set; }
        public DbSet<User> user { get; set; }



    }

}
