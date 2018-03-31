using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WebAppIOT.Models
{
    public class User
    {
        public int userID { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        [Required]
        public string login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string pwd { get; set; }
        public System system { get; set; }


    }
}
