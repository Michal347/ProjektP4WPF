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
        public CityModel Departure { get; set; }
        public CityModel Arrival { get; set; }
        public int SeatNumber { get; set; }
        public string IdNumber { get; set; }
        public DateTime ReservationDate { get; set; }
        public int ComfortClass { get; set; }
        public UserModel User { get; set; }
    }
}
