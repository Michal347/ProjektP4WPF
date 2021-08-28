using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjektP4WPF.ViewModels
{
    class LoginViewModel : BaseViewModel, IPopupWindow
    {

        public ICommand LoginCommand { get; private set; }


        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(x => LoginUser());
        }

        private void LoginUser()
        {
            Password = "Dummy password";
            Login = "Test data";
        }


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

        public string Name => throw new NotImplementedException();

        public int Width => throw new NotImplementedException();

        public int Height => throw new NotImplementedException();
        #endregion

    }
}
