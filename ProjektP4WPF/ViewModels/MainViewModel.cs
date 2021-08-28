using ProjektP4WPF.DAL;
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

        #region Private fields



        #endregion
        #region ICommands
        public IAsyncCommand BookFlightCommand { get; private set; }

        #endregion

        #region Event rising fields

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

        #endregion


        #region Ctor

        public MainViewModel()
        {
            Initiliaze();
            BookFlightCommand = new AsyncCommand(BookFlight);



            
        }

        #endregion

        #region Command actions

        private async Task BookFlight()
        {
            throw new NotImplementedException();
        }

        #endregion

        void Initiliaze()
        {
            using (var context = new AirportDbContext())
            {
                Cities = context.Cities.ToDictionary(x => x.Id, y => y.Name);
            }
        }
    }
}
