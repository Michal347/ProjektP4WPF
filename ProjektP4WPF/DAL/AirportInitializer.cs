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
                new CityModel() { Name = "New Yrok"},
                new CityModel() { Name = "Boston"},
                new CityModel() { Name = "Ohio"},
                new CityModel() { Name = "New Dehli"},
                new CityModel() { Name = "Alaska"},
                new CityModel() { Name = "Tokio"},
                new CityModel() { Name = "Warsaw"},
                new CityModel() { Name = "Toronto"},
                new CityModel() { Name = "Paris"},
                new CityModel() { Name = "Venice"},
            };

            cities.ForEach(s => context.Cities.Add(s));
            context.SaveChanges();


            var flights = new List<FlighDataModel>
            {
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = true },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = true },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = true },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = true },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = true },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = true },
                new FlighDataModel() {ArrivalCity = 1, DepartureCity = 2, ArrivalDate = DateTime.Now, DepartureDate = DateTime.Now, Premium = true },
                new FlighDataModel() {ArrivalCity = 3, DepartureCity = 5, ArrivalDate = DateTime.Now.AddDays(1), DepartureDate = DateTime.Now.AddDays(-1), Premium = true }
            };

            flights.ForEach(s => context.Flights.Add(s));
            context.SaveChanges();
        }
    }
}
