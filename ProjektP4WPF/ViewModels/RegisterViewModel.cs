using ProjektP4WPF.DAL;
using ProjektP4WPF.Models;
using ProjektP4WPF.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjektP4WPF.ViewModels
{
    class RegisterViewModel : BaseViewModel, INotifyPropertyChanged
    {
        #region ICommands
        public ICommand GoBack { get; private set; }
        public ICommand Register { get; private set; }
        #endregion

        #region Ctors
        public RegisterViewModel()
        {
            GoBack = new RelayCommand(x => GoBackHandler());
            Register = new RelayCommand(x => RegisterUser());
        }
        #endregion

        #region Event rising fields

        private string login;

        public string Login
        {
            get { return login; }
            set 
            { 
                login = value;
                OnPropertyChanged("Login");
                ClearPropertyErrors(this, "Login");
            }
        }

        private string passsword;

        public string Password
        {
            get { return passsword; }
            set 
            { 
                passsword = value;
                OnPropertyChanged("Pasword");
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set 
            { 
                surname = value;
                OnPropertyChanged("Surname");
            }
        }


        #endregion

        #region ICommand handlers
        private void GoBackHandler()
        {
            CancelRequested.Invoke(this, null);
        }

        private void RegisterUser()
        {
            var hash = PasswordHasher.HashPassword(Password);
            UserModel output;
            using (var context = new AirportDbContext())
            {
                var user = context.Users.FirstOrDefault(x => x.Login == Login);
                if(user != null)
                {
                    OnErrorCreated("Login", "Username already in use");
                    return;
                }


                output = context.Users.Add(new UserModel() { Login = Login, Name = Name, Password = hash, Surname = Surname});
                context.SaveChanges();
            }

            RegisterSucceded.Invoke(this, output);
        }

        #endregion

        public event EventHandler<UserModel> RegisterSucceded;
        public event EventHandler CancelRequested;




    }
}
