using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp.Data.Entities
{
    public class SeriesAvance
    {
        [Key]
        public int Id { get; set; }
        public string idSerieAvance { get; set; }
        public string claveSeries { get; set; }
        public string idRutina { get; set; }
        public string idCircuito { get; set; }
        public string seriesFinalizadas { get; set; }
        public double PesoUsado { get; set; }
        public string UnidadMedida { get; set; }
    }
}
