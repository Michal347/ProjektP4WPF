using ProjektP4WPF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4WPF.ViewModels
{
    class ReservationViewModel
    {

        public int ReservationId { get; private set; }//
        public int FlightId { get; private set; }//
        public string DepartureCity { get; private set; }//
        public string ArrivalCity { get; private set; }//
        public DateTime DepartureDate { get; private set; }//
        public DateTime ArrivalDate { get; private set; }//
        public bool Premium { get; private set; }//
        public int SeatNumber { get; private set; }//
        public DateTime ReservationDate { get; private set; }//
        public string Name { get; private set; }//
        public string Surname { get; private set; }//
        public string Username { get; private set; }//

        public ReservationViewModel(int reservationId)
        {
            ReservationId = reservationId;
            using (var context = new AirportDbContext())
            {
                var result = context.Reservations.FirstOrDefault(x => x.Id == ReservationId);
                if( result != null )
                {
                    var user = context.Users.FirstOrDefault(x => x.Id == result.User);
                    {
                        var flight = context.Flights.FirstOrDefault(x => x.Id == result.FlightId);

                        FlightId = result.FlightId;
                        SeatNumber = result.SeatNumber;
                        ReservationDate = result.ReservationDate;
                        Premium = result.Premium;
                        Name = result.Name;
                        Surname = result.Surname;
                        Username = user.Login;

                        DepartureDate = flight.DepartureDate;
                        ArrivalDate = flight.ArrivalDate;

                        DepartureCity = context.Cities.FirstOrDefault(x => x.Id == flight.DepartureCity)?.Name;
                        ArrivalCity =  context.Cities.FirstOrDefault(x => x.Id == flight.ArrivalCity)?.Name;
                    }
                }
            }
        }
    }
}
