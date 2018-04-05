using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppIOT.Models
{
    public class CapteurSenario
    {
        public int ID{ get; set; }
        public int Link_type { get; set; }
        public int Link_num { get; set; }
        public int Seuil { get; set; }
        public virtual ICollection<Senario> Senarios { get; set; }
    }
}
