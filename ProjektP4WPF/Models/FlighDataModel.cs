using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4WPF.Models
{
    public class FlighDataModel
    {
        [Key]
        public int Id { get; set; }
        public int DepartureCity { get; set; }
        public int ArrivalCity { get; set; }
        public bool Premium { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}
