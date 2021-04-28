using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sallon_Appointment_API.Models;

namespace Sallon_Appointment_API.Data
{
    public class Sallon_Appointment_APIContext : DbContext
    {
        public Sallon_Appointment_APIContext (DbContextOptions<Sallon_Appointment_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Sallon_Appointment_API.Models.Sallon> Sallon { get; set; }
    }
}
