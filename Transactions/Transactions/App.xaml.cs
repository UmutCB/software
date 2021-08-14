using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Transactions.ViewModel;
using WPFLocalizeExtension;
using System.Threading;
using System.Globalization;

namespace Transactions
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Transactions.MainWindow window = new MainWindow();
            UserViewModel model = new UserViewModel();
            window.DataContext = model;
            window.Show();

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            System.Threading.Thread.CurrentThread.CurrentUICulture= new CultureInfo("en");
        }
    }
}
