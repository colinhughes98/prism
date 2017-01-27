using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;

namespace Betting.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel()
        {

        }

        string _message = "Hello World";

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
    }
}
