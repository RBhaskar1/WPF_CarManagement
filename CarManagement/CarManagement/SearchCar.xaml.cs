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
    /// Interaction logic for SearchCar.xaml
    /// </summary>
    public partial class SearchCar : Window
    {
        List<CarDetailsViewModel> Cars;

        public SearchCar()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //System.Windows.Data.CollectionViewSource carModelViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("carModelViewSource")));
            //// Load data by setting the CollectionViewSource.Source property:
            //// carModelViewSource.Source = [generic data source]
            //System.Windows.Data.CollectionViewSource carFeatureViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("carFeatureViewSource")));
            //// Load data by setting the CollectionViewSource.Source property:
            //// carFeatureViewSource.Source = [generic data source]
            //System.Windows.Data.CollectionViewSource individualCarViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("individualCarViewSource")));
            //// Load data by setting the CollectionViewSource.Source property:
            //// individualCarViewSource.Source = [generic data source]
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            bool cont = true;

            foreach(var c in Cars)
            {
                if (cont)
                {
                    cont = DataStore.UpdateObjects(c);
                }
            }

            if (cont)
            {
                CarGrid.Items.Refresh();
                MessageBox.Show("Updated Successfully!!");
            }
            else
                MessageBox.Show("Something Went Wrong. Contact your system administrator.");
        }

        private void searchbtn_Click(object sender, RoutedEventArgs e)
        {

            if (Utility.validEmptyFields(grid1))
            {
                string model = searchText.Text;
                Cars = DataStore.SearchCarByModel(model);
                CarGrid.ItemsSource = Cars;
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
