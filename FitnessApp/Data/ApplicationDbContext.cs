using FitnessApp.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Ejercicio> Ejercicos { get; set; }
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Circuito> Circuito { get; set; }  
        public DbSet<Rutina> Rutinas { get; set; }  
        public DbSet<Avance> Avances { get; set; }
        public DbSet<SeriesAvance> SeriesAvances { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
