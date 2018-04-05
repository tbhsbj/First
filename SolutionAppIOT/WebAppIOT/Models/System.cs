using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppIOT.Models
{
    public class System
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Ip { get; set; }
        public Double Longitude { get; set; }
        public Double Latitude { get; set; }
        public virtual ICollection<User> users { get; set; }
        public virtual ICollection<Technicien_System> Technicien_Systems { get; set; }
        public int SuperUserID { get; set; }
        public virtual SuperUser SuperUser { get; set; }
    }
}
