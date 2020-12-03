using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DSED_06_AdoptAPet.Models
{
    public class Dogs
    {
        [Key]
        public int ID { get; set; }
        public string DogName { get; set; }
        public string Age { get; set; }
        public string Breed { get; set; }
        public string Illness { get; set; }
        public DateTime EnteredShelter { get; set; }

    }
}
