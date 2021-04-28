using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sallon_Appointment_API.Models
{
    public class Sallon
    {
        [Key]
        public int Sallon_ID { get; set; }

        public string Client { get; set; }

        public string Hairdresser { get; set; }

        public string Haircut { get; set; }
    }
}
