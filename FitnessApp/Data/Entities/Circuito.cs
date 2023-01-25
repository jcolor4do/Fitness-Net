using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp.Data.Entities
{
    public class Circuito
    {
        [Key]
        public string Id { get; set; }
        public string idCircuito { get; set; }
        public string clavecircuito { get; set; }
        public string series { get; set; }
        public string ejercicio { get; set; }
        
         }
}
