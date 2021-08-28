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

        }
    }
}
