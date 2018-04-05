using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppIOT.Models
{
    public class Technicien
    {
        public int TechnicienId { get; set; }
        public string Cin { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Technicien_System> Technicien_Systems { get; set; }
    }
}
