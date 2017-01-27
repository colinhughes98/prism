using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Betting.Views;
using Prism.Unity;


namespace Betting
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window) Shell;            
            Application.Current.MainWindow.Show();
        }
    }
}
