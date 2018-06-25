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
using System.Windows.Shapes;
using DAL;

namespace CarManagement
{
    /// <summary>
    /// Interaction logic for DisplayCars.xaml
    /// </summary>
    public partial class DisplayCars : Window
    {
        System.Windows.Data.CollectionViewSource individualCarViewSource;

        public DisplayCars()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            individualCarViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("individualCarViewSource")));

            individualCarViewSource.Source = DataStore.GetAvailableCars();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            individualCarViewSource.View.MoveCurrentToNext();
        }

        private void previous_Click(object sender, RoutedEventArgs e)
        {
            individualCarViewSource.View.MoveCurrentToPrevious();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void back_Copy_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
