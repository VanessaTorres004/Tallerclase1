using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tallerclase1.Models;

namespace Tallerclase1.Data
{
    public class Tallerclase1Context : DbContext
    {
        public Tallerclase1Context (DbContextOptions<Tallerclase1Context> options)
            : base(options)
        {
        }

        public DbSet<Tallerclase1.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<Tallerclase1.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<Tallerclase1.Models.jugadores> jugadores { get; set; } = default!;
    }
}
