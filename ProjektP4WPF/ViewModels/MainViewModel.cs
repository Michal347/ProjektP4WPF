using ProjektP4WPF.DAL;
using ProjektP4WPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjektP4WPF.ViewModels
{
    class MainViewModel : BaseViewModel, INotifyPropertyChanged
    {
        #region ICommands
        public ICommand BookFlightCommand { get; private set; }

        public ICommand SearchFlightCommand { get; private set; }

        public ICommand RefreshHistoryCommand { get; private set; }

        #endregion

        #region Event rising fields

        public int UserId { get; set; }

        private Dictionary<int, string> depratureCities;

        public Dictionary<int, string> Cities
        {
            get { return depratureCities; }
            set { depratureCities = value; OnPropertyChanged("DepartureCities"); }
        }

        private int selectedDepartureCity;

        public int SelectedDepartureCity
        {
            get { return selectedDepartureCity; }
            set { selectedDepartureCity = value; OnPropertyChanged("SelectedDepartureCity"); }
        }

        private int selectedArrivalCity;

        public int SelectedArrivalCity
        {
            get { return selectedArrivalCity; }
            set { selectedArrivalCity = value; OnPropertyChanged("SelectedArrivalCity"); }
        }

        private string passengerName;

        public string PassengerName
        {
            get { return passengerName; }
            set { passengerName = value; OnPropertyChanged("PassengerName"); }
        }

        private string passengerSurname;

        public string PassengerSurname
        {
            get { return passengerSurname; }
            set { passengerSurname = value; OnPropertyChanged("PassengerSurname"); }
        }

        private DateTime departureDate;

        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; OnPropertyChanged("DepartureDate"); }
        }

        private bool premium;

        public bool Premium
        {
            get { return premium; }
            set { premium = value; OnPropertyChanged("Premium"); }
        }

        private List<FlightViewModel> availableFlights;

        public List<FlightViewModel> AvailableFlights
        {
            get { return availableFlights; }
            set { availableFlights = value; OnPropertyChanged("AvailableFlights"); }
        }


        private FlightViewModel selectedFlight;

        public FlightViewModel SelectedFlight
        {
            get { return selectedFlight; }
            set 
            { 
                selectedFlight = value;
                OnPropertyChanged("SelectedFlight");
            }
        }

        private List<ReservationViewModel> reservation;

        public List<ReservationViewModel> Reservations
        {
            get { return reservation; }
            set 
            { 
                reservation = value;
                OnPropertyChanged("Reservations");
            }
        }

        #endregion


        #region Ctor

        public MainViewModel()
        {
            Initiliaze();
            BookFlightCommand = new RelayCommand(x => BookFlight());
            SearchFlightCommand = new RelayCommand(x => SearchFlight());
            RefreshHistoryCommand = new RelayCommand(x => RefreshHistory());
        }



        #endregion

        #region Command actions


        private void RefreshHistory()
        {
            RefreshBookings();
        }

        private void SearchFlight()
        {
            List<FlighDataModel> records = new List<FlighDataModel>() ;
            using (var context = new AirportDbContext())
            {
                records = context.Flights.Where(x =>
                x.DepartureCity == SelectedDepartureCity &&
                x.ArrivalCity == SelectedArrivalCity &&
                x.Premium == Premium
                ).ToList();

                var timed = records.Where(x => x.DepartureDate.Date == DepartureDate);
            }

            AvailableFlights = records.Select(x => new FlightViewModel(x.Id)).ToList();
        }

        private void BookFlight()
        {
            if (SelectedFlight != null)
            {
                using (var context = new AirportDbContext())
                {
                    context.Reservations.Add(
                        new ReservationDataModel()
                        {
                            Premium = SelectedFlight.Premium,
                            FlightId = SelectedFlight.FlightId,
                            ReservationDate = DateTime.Now,
                            SeatNumber = new Random().Next(255),
                            User = UserId,
                            Name = PassengerName,
                            Surname = PassengerSurname
                        }
                    );

                    context.SaveChanges();
                }
            }
            RefreshBookings();
        }

        #endregion

        void Initiliaze()
        {
            using (var context = new AirportDbContext())
            {
                Cities = context.Cities.ToDictionary(x => x.Id, y => y.Name);
            }

            DepartureDate = DateTime.Now;
        }

        private void RefreshBookings()
        {
            List<ReservationDataModel> result = new List<ReservationDataModel>();
            using (var context = new AirportDbContext())
            {
                result = context.Reservations.ToList();
            }

            Reservations = result.Select(x => new ReservationViewModel(x.Id)).ToList();
        }
    }
}
