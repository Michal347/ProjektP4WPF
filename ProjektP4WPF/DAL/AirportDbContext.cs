using ProjektP4WPF.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace ProjektP4WPF.DAL
{
    public class AirportDbContext : DbContext
    {
        // Your context has been configured to use a 'AirportDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ProjektP4WPF.DAL.AirportDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AirportDbContext' 
        // connection string in the application configuration file.
        public AirportDbContext()
            : base("name=AirportDbContext")
        {
            Database.SetInitializer(new AirportInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<UserModel> Users { get; set; }
        public DbSet<CityModel> Cities { get; set; }
        public DbSet<ReservationDataModel> Reservations { get; set; }
        public DbSet<FlighDataModel> Flights { get; set; }
    }
}