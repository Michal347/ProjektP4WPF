using ProjektP4WPF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4WPF.ViewModels
{
    public class FlightViewModel
    {
        public int FlightId { get; private set; }
        public string DepartureCity { get; private set; }
        public string ArrivalCity { get; private set; }
        public DateTime DepartureDate { get; private set; }
        public DateTime ArrivalDate { get; private set; }
        public bool Premium { get; private set; } 

        public FlightViewModel(int flightId)
        {
            FlightId = flightId;
            using (var context = new AirportDbContext())
            {
                var flight = context.Flights.FirstOrDefault(x => x.Id == flightId);
                var departureCity = context.Cities.FirstOrDefault(x => x.Id == flight.DepartureCity);
                var arrivalCity = context.Cities.FirstOrDefault(x => x.Id == flight.ArrivalCity);

                DepartureCity = departureCity.Name;
                ArrivalCity = arrivalCity.Name;
                Premium = flight.Premium;
                DepartureDate = flight.DepartureDate;
                ArrivalDate = flight.ArrivalDate;
            }
        }
    }
}
