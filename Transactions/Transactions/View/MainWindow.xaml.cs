using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using Transactions.ViewModel;
using Microsoft.Win32;
using System.IO;

namespace Transactions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        UserViewModel user = new UserViewModel();
        private void ValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            user.addXML(txtItem.Text, Convert.ToInt32(txtAmount.Text));
            grd.ItemsSource = null;
            grd.Items.Refresh();
            grd.ItemsSource = user.Users;

        }
        private void deleteButton_Click(Object sender, RoutedEventArgs e)
        {
            object row = grd.SelectedItem;
            int column = grd.Columns.ElementAt(0).DisplayIndex;
            string item = (grd.SelectedCells[column].Column.GetCellContent(row) as TextBlock).Text;
            column = grd.Columns.ElementAt(1).DisplayIndex;
            int amount = Convert.ToInt32((grd.SelectedCells[column].Column.GetCellContent(row) as TextBlock).Text);
            user.deleteXML(item, amount);
            grd.ItemsSource = null;
            grd.Items.Refresh();
            grd.ItemsSource = user.Users;
        }
        private void loadButton_Click(Object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "XML|*.xml";
            file.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            string fle="";
            if(file.ShowDialog()==true)
            {
                fle = file.FileName;
            }
            UserViewModel user = new UserViewModel();
            user.loadXML(fle);
            grd.ItemsSource = null;
            grd.Items.Refresh();
            grd.ItemsSource = user.Users;
        }
    }
}
