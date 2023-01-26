using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp.Data.Entities
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string idUsuario { get; set; }
        public string password { get; set; }
        public String nombre { get; set; }
        public int edad { get; set; }
        public String correo { get; set; }
        public int estatura { get; set; }
        public double peso { get; set; }
        public String genero { get; set; }
        public String complexion { get; set; }
        public int diasActividad { get; set; }
        public String meta { get; set; }
        public double imc { get; set; }

    }
}
