using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DSED_06_AdoptAPet.Models
{
    public class Appointment // this class will be used once i get the adoption part of the project done
    {
        [Key]
        public int AppointmentID { get; set; }
        public DateTime AppointmentDate { get; set; }

        [ForeignKey("Dogs")]
        public int DogIDFK { get; set; }
        [ForeignKey("User")]
        public int UserIDFK { get; set; }

        public Dogs Dogs { get; set; }
        public User User { get; set; }

    }
}
