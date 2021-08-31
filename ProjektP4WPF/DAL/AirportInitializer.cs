using ProjektP4WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4WPF.DAL
{
    class AirportInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<AirportDbContext>
    {
        protected override void Seed(AirportDbContext context)
        {
            var cities = new List<CityModel>
            {
                new CityModel() { Name = "London"},
                new CityModel() { Name = "New York"},      
                new CityModel() { Name = "Warsaw"},
                new CityModel() { Name = "Paris"},

            };

            cities.ForEach(s => context.Cities.Add(s));
            context.SaveChanges();


            var flights = new List<FlighDataModel>
            {
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now.AddHours(18), DepartureDate = DateTime.Now.AddHours(5), Premium = true },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now.AddHours(30), DepartureDate = DateTime.Now.AddHours(8), Premium = false },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now.AddHours(15), DepartureDate = DateTime.Now.AddHours(1), Premium = false },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now.AddHours(14), DepartureDate = DateTime.Now.AddMinutes(30), Premium = true },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 1, ArrivalDate = DateTime.Now.AddHours(23), DepartureDate = DateTime.Now.AddHours(4), Premium = true },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 1, ArrivalDate = DateTime.Now.AddHours(18), DepartureDate = DateTime.Now.AddHours(2), Premium = false },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 1, ArrivalDate = DateTime.Now.AddHours(24), DepartureDate = DateTime.Now.AddHours(8), Premium = false },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 1, ArrivalDate = DateTime.Now.AddHours(14), DepartureDate = DateTime.Now.AddMinutes(35), Premium = true },

                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 4, ArrivalDate = DateTime.Now.AddHours(3), DepartureDate = DateTime.Now.AddMinutes(45), Premium = false },
                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 4, ArrivalDate = DateTime.Now.AddHours(8), DepartureDate = DateTime.Now.AddHours(5), Premium = true },
                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 4, ArrivalDate = DateTime.Now.AddHours(9), DepartureDate = DateTime.Now.AddHours(6), Premium = true },
                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 4, ArrivalDate = DateTime.Now.AddHours(5), DepartureDate = DateTime.Now.AddHours(2), Premium = true },
                new FlighDataModel() {ArrivalCity = 4, DepartureCity = 3, ArrivalDate = DateTime.Now.AddHours(11), DepartureDate = DateTime.Now.AddHours(8), Premium = true },
                new FlighDataModel() {ArrivalCity = 4, DepartureCity = 3, ArrivalDate = DateTime.Now.AddHours(6), DepartureDate = DateTime.Now.AddHours(3), Premium = false },
                new FlighDataModel() {ArrivalCity = 4, DepartureCity = 3, ArrivalDate = DateTime.Now.AddHours(10), DepartureDate = DateTime.Now.AddHours(7), Premium = false },
                new FlighDataModel() {ArrivalCity = 4, DepartureCity = 3, ArrivalDate = DateTime.Now.AddHours(15), DepartureDate = DateTime.Now.AddHours(12), Premium = true },

                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 2, ArrivalDate = DateTime.Now.AddHours(18), DepartureDate = DateTime.Now.AddHours(5), Premium = true },
                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 2, ArrivalDate = DateTime.Now.AddHours(30), DepartureDate = DateTime.Now.AddHours(8), Premium = false },
                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 2, ArrivalDate = DateTime.Now.AddHours(15), DepartureDate = DateTime.Now.AddHours(1), Premium = false },
                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 2, ArrivalDate = DateTime.Now.AddHours(14), DepartureDate = DateTime.Now.AddMinutes(30), Premium = true },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 3, ArrivalDate = DateTime.Now.AddHours(23), DepartureDate = DateTime.Now.AddHours(4), Premium = true },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 3, ArrivalDate = DateTime.Now.AddHours(18), DepartureDate = DateTime.Now.AddHours(2), Premium = false },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 3, ArrivalDate = DateTime.Now.AddHours(24), DepartureDate = DateTime.Now.AddHours(8), Premium = false },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 3, ArrivalDate = DateTime.Now.AddHours(14), DepartureDate = DateTime.Now.AddMinutes(35), Premium = true },

                  new FlighDataModel() {ArrivalCity = 4, DepartureCity = 2, ArrivalDate = DateTime.Now.AddHours(18), DepartureDate = DateTime.Now.AddHours(5), Premium = true },
                new FlighDataModel() {ArrivalCity = 4, DepartureCity = 2, ArrivalDate = DateTime.Now.AddHours(30), DepartureDate = DateTime.Now.AddHours(8), Premium = false },
                new FlighDataModel() {ArrivalCity = 4, DepartureCity = 2, ArrivalDate = DateTime.Now.AddHours(15), DepartureDate = DateTime.Now.AddHours(1), Premium = false },
                new FlighDataModel() {ArrivalCity = 4, DepartureCity = 2, ArrivalDate = DateTime.Now.AddHours(14), DepartureDate = DateTime.Now.AddMinutes(30), Premium = true },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 4, ArrivalDate = DateTime.Now.AddHours(23), DepartureDate = DateTime.Now.AddHours(4), Premium = true },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 4, ArrivalDate = DateTime.Now.AddHours(18), DepartureDate = DateTime.Now.AddHours(2), Premium = false },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 4, ArrivalDate = DateTime.Now.AddHours(24), DepartureDate = DateTime.Now.AddHours(8), Premium = false },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 4, ArrivalDate = DateTime.Now.AddHours(14), DepartureDate = DateTime.Now.AddMinutes(35), Premium = true },

                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 1, ArrivalDate = DateTime.Now.AddHours(3), DepartureDate = DateTime.Now.AddMinutes(45), Premium = false },
                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 1, ArrivalDate = DateTime.Now.AddHours(8), DepartureDate = DateTime.Now.AddHours(5), Premium = true },
                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 1, ArrivalDate = DateTime.Now.AddHours(9), DepartureDate = DateTime.Now.AddHours(6), Premium = false },
                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 1, ArrivalDate = DateTime.Now.AddHours(5), DepartureDate = DateTime.Now.AddHours(2), Premium = true },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 3, ArrivalDate = DateTime.Now.AddHours(11), DepartureDate = DateTime.Now.AddHours(8), Premium = true },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 3, ArrivalDate = DateTime.Now.AddHours(6), DepartureDate = DateTime.Now.AddHours(3), Premium = true },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 3, ArrivalDate = DateTime.Now.AddHours(10), DepartureDate = DateTime.Now.AddHours(7), Premium = false },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 3, ArrivalDate = DateTime.Now.AddHours(15), DepartureDate = DateTime.Now.AddHours(12), Premium = false },

                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 4, ArrivalDate = DateTime.Now.AddHours(3), DepartureDate = DateTime.Now.AddMinutes(45), Premium = false },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 4, ArrivalDate = DateTime.Now.AddHours(8), DepartureDate = DateTime.Now.AddHours(5), Premium = true },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 4, ArrivalDate = DateTime.Now.AddHours(9), DepartureDate = DateTime.Now.AddHours(6), Premium = false },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 4, ArrivalDate = DateTime.Now.AddHours(5), DepartureDate = DateTime.Now.AddHours(2), Premium = true },
                new FlighDataModel() {ArrivalCity = 4, DepartureCity = 1, ArrivalDate = DateTime.Now.AddHours(11), DepartureDate = DateTime.Now.AddHours(8), Premium = true },
                new FlighDataModel() {ArrivalCity = 4, DepartureCity = 1, ArrivalDate = DateTime.Now.AddHours(6), DepartureDate = DateTime.Now.AddHours(3), Premium = false },
                new FlighDataModel() {ArrivalCity = 4, DepartureCity = 1, ArrivalDate = DateTime.Now.AddHours(10), DepartureDate = DateTime.Now.AddHours(7), Premium = false },
                new FlighDataModel() {ArrivalCity = 4, DepartureCity = 1, ArrivalDate = DateTime.Now.AddHours(15), DepartureDate = DateTime.Now.AddHours(12), Premium = true },

            };

            flights.ForEach(s => context.Flights.Add(s));
            context.SaveChanges();
        }
    }
}
