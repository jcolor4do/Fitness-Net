using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp.Data.Entities
{
    public class Ejercicio
    {
        [Key]
        public int Id { get; set; }
        public string nombre { get; set; }
        public int repeticiones { get; set; }
        public byte[] imagen { get; set; }
    }
}
