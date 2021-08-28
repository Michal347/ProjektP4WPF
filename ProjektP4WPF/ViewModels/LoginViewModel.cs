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
    class LoginViewModel : BaseViewModel, INotifyPropertyChanged
    {

        #region ICommands
        public ICommand LoginCommand { get; private set; }
        public ICommand RegisterCommand { get; private set; }
        #endregion

        public event EventHandler<UserModel> LoginCompleted;

        public event EventHandler<string> RegisterRequested;

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(x => LoginUser());
            RegisterCommand = new RelayCommand(x => Register());
        }

        #region ICommand handlers
        private void LoginUser()
        {
            UserModel output;
            using (var context = new AirportDbContext())
            {
                var found = context.Users.FirstOrDefault(x => x.Login == UserLogin);
                if (found != null) {
                    var valid = PasswordHasher.ComparePassowrds(found.Password, Password);
                    if (!valid)
                    {
                        OnErrorCreated("UserLogin", "incorrect login or password"); 
                        OnErrorCreated("Password", "incorrect login or password");
                        return;
                    }
                    output = new UserModel() { Name = found.Name, Surname = found.Surname, Id = found.Id};
                } else
                {
                    OnErrorCreated("UserLogin", "incorrect login or password");
                    OnErrorCreated("Password", "incorrect login or password");
                    return;
                }
            }

            LoginCompleted.Invoke(this, output);
        }

        private void Register()
        {
            RegisterRequested.Invoke(this, UserLogin);
        }

        #endregion


        #region Event rising fields

        private string userLogin;

        public string UserLogin
        {
            get { return userLogin; }
            set 
            {
                userLogin = value;
                OnPropertyChanged("UserLogin");
                ClearPropertyErrors(this, "UserLogin");
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set 
            { 
                password = value;
                OnPropertyChanged("Password");
                ClearPropertyErrors(this, "Password");
            }
        }

        #endregion

    }
}
