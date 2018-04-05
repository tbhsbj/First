using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppIOT.Models
{
    public class Senario
    {
        public int ID { get; set; }
        public int Active { get; set; }
        public DateTime temps { get; set; }
        public virtual ICollection<Senario_Equipement> Equipemets { get; set; }
        public int CapteurSenarioID { get; set; }
        public virtual CapteurSenario CapteurSenario { get; set; }
    }
}
