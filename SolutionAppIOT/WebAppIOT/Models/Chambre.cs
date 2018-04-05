using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppIOT.Models
{
    public class Chambre
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Lastlogin { get; set; }
        public virtual int UserID { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Equipement> Equipemets { get; set; }
    }
}
