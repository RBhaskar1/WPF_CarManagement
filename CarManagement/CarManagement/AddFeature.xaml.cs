using DAL;
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

namespace CarManagement
{
    /// <summary>
    /// Interaction logic for AddFeature.xaml
    /// </summary>
    public partial class AddFeature : Window
    {
        public AddFeature()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource carFeatureViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("carFeatureViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // carFeatureViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource individualCarViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("individualCarViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // individualCarViewSource.Source = [generic data source]
        }

        private void CarFeature_Click(object sender, RoutedEventArgs e)
        {
            if (Utility.validEmptyFields(grid1))
            {
                if (Utility.validEmptyFields(grid2))
                {
                    bool success = false;
                    string exception = "exception not captured properly";

                    CarFeature cf = new CarFeature
                    {
                        Car_Feature_Description = car_Feature_DescriptionTextBox.Text
                    };

                    var resp = DataStore.AddObject(cf, "CarFeatures");
                    success = resp.Item1;
                    exception = resp.Item2 ?? "Car Feature worked fine";

                    if (success)
                    {
                        int featureID = DataStore.GetFeatureID(car_Feature_DescriptionTextBox.Text);

                        if (featureID != -1)
                        {
                            FeaturesOnCar f = new FeaturesOnCar
                            {
                                Car_For_Sale_ID = Convert.ToInt16(carIDTextBox.Text),
                                Car_Feature_ID = featureID
                            };

                            var resp2 = DataStore.AddObject(f, "FeaturesOnCar");
                            success = resp2.Item1;
                            exception = resp2.Item2;
                        }
                    }

                    if (success)
                        MessageBox.Show("Successfully Added New Car Feature!");
                    else
                        MessageBox.Show("Something went wrong please try again later.");
                }
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
