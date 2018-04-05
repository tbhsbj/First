using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppIOT.Models
{
    public class IotContext : DbContext
    {
        public IotContext(DbContextOptions<IotContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<CapteurSenario> CapteurSenario { get; set; }
        public DbSet<Chambre> Chambre { get; set; }
        public DbSet<Equipement> Equipement { get; set; }
        public DbSet<Senario> Senario { get; set; }
        public DbSet<Senario_Equipement> Senario_Equipement { get; set; }
        public DbSet<SuperUser> SuperUser { get; set; }
        public DbSet<System> System { get; set; }
        public DbSet<Technicien> Technicien { get; set; }
        public DbSet<Technicien_System> Technicien_System { get; set; }


    }
}
