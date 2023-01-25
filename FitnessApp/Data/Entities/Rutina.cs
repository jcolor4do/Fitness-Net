using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp.Data.Entities
{
    public class Rutina
    {
        [Key]
        public int Id { get; set; }
        public string IdRutina { get; set; }
        public string idUsuario { get; set; }
        public string descripcionDia { get; set; }
        public string idCircuito { get; set; }
    }
}
