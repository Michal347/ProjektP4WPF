using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4WPF.Models
{
    public class ReservationDataModel
    {
        [Key]
        public int Id { get; set; }
        public int FlightId { get; set; }
        public int SeatNumber { get; set; }
        public DateTime ReservationDate { get; set; }
        public bool Premium { get; set; }
        public int User { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
