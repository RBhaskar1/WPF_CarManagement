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

namespace CarManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (StaticUser.Role.Contains("Admin"))
            {
                addCar.IsEnabled = true;
                addModel.IsEnabled = true;
                searchUpdate.IsEnabled = true;
                addFeature.IsEnabled = true;
                displayCars.IsEnabled = true;
            }else if (StaticUser.Role.Contains("Staff"))
            {
                displayCars.IsEnabled = true;
            }
        }

        private void addCar_Click(object sender, RoutedEventArgs e)
        {
            AddCar main = new AddCar();
            main.Show();
            this.Close();
        }

        private void addFeature_Click(object sender, RoutedEventArgs e)
        {
            AddFeature main = new AddFeature();
            main.Show();
            this.Close();
        }

        private void addModel_Click(object sender, RoutedEventArgs e)
        {
            AddModel main = new AddModel();
            main.Show();
            this.Close();
        }

        private void displayCars_Click(object sender, RoutedEventArgs e)
        {
            DisplayCars main = new DisplayCars();
            main.Show();
            this.Close();
        }

        private void searchUpdate_Click(object sender, RoutedEventArgs e)
        {
            SearchCar main = new SearchCar();
            main.Show();
            this.Close();
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            Login main = new Login();
            main.Show();
            this.Close();
        }
    }
}
