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
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = true },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = false },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = false },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = true },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 1, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = true },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 1, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = false },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 1, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = false },
                new FlighDataModel() {ArrivalCity = 2, DepartureCity = 1, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = true },
                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 4, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = false },
                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 4, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = true },
                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 4, ArrivalDate = DateTime.Now.AddDays(1), DepartureDate = DateTime.Now.AddDays(-1), Premium = true }
            };

            flights.ForEach(s => context.Flights.Add(s));
            context.SaveChanges();
        }
    }
}
