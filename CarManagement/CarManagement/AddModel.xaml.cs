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
    /// Interaction logic for AddModel.xaml
    /// </summary>
    public partial class AddModel : Window
    {
        public AddModel()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource carModelViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("carModelViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // carModelViewSource.Source = [generic data source]
        }

        private void addCarModel_Click(object sender, RoutedEventArgs e)
        {
            if (Utility.validEmptyFields(grid1))
            {
                CarModel cm = new CarModel
                {
                    EngineSize = Convert.ToDouble(engineSizeTextBox.Text),
                    Manufacturer = manufacturerTextBox.Text,
                    Model = modelTextBox.Text,
                    ModelID = Convert.ToInt16(modelIDTextBox.Text),
                    NumberOfSeats = Convert.ToInt16(numberOfSeatsTextBox.Text)
                };

                var resp = DataStore.AddObject(cm, "CarModels");

                if (resp.Item1)
                    MessageBox.Show("Successfully Added New Car");
                else
                    MessageBox.Show("Something went wrong please try again later.", resp.Item2);
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
