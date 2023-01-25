using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp.Data.Entities
{
    public class Avance
    {
        [Key]
        public int Id { get; set; }
        public string idAvance { get; set; }
        public DateTime fecha { get; set; }
        public int idSerieAvance { get; set; }
    
        }
    }

