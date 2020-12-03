using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSED_06_AdoptAPet.Models
{
    public class Daycare
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PetName { get; set; }
        public string Breed { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }



    }
}
