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
    /// Interaction logic for AddCar.xaml
    /// </summary>
    public partial class AddCar : Window
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource individualCarViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("individualCarViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // individualCarViewSource.Source = [generic data source]
        }

        private void submitCar_Click(object sender, RoutedEventArgs e)
        {
            if(Utility.validEmptyFields(grid1))
            {
                IndividualCar car = new IndividualCar
                {
                    Body_Type = body_TypeTextBox.Text,
                    Colour = colourTextBox.Text,
                    Current_Mileage = current_MileageTextBox.Text,
                    Date_Imported = date_ImportedTextBox.Text,
                    Manufacture_Year = Convert.ToInt16(manufacture_YearTextBox.Text),
                    //CarID = Convert.ToInt16(carIDTextBox.Text),
                    Model_ID = Convert.ToInt16(model_IDTextBox.Text),
                    Status = statusTextBox.Text,
                    Transmission = transmissionTextBox.Text
                };
                var resp = DataStore.AddObject(car, "IndividualCars");

                if (resp.Item1)
                    MessageBox.Show("Successfully Added New Car");
                else
                    if (!resp.Item2.Contains("CarModel"))
                    MessageBox.Show("Something went wrong please try again later.", resp.Item2);
                else
                {
                    MessageBox.Show("Please Add a model before adding the Cars for it.", resp.Item2);
                    AddModel main = new AddModel();
                    main.Show();
                    this.Close();
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
