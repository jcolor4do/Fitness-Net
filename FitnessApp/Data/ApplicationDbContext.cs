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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
