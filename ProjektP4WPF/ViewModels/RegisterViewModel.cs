using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4WPF.ViewModels
{
    class RegisterViewModel : BaseViewModel, IPopupWindow
    {
        public string Name => "Register";

        public int Width => 400;

        public int Height => 400;
    }
}
