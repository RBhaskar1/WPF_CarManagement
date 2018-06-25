using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CarDetailsViewModel
    {
        public int CarID { get; set; }
        public string Colour { get; set; }
        public string Current_Mileage { get; set; }
        public string Date_Imported { get; set; }
        public int Manufacture_Year { get; set; }
        public string Transmission { get; set; }
        public string Status { get; set; }
        public string Body_Type { get; set; }
        public int Model_ID { get; set; }

        public int FeatureID { get; set; }
        public string Car_Feature_Description { get; set; }

        public int ModelID { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int NumberOfSeats { get; set; }
        public double EngineSize { get; set; }
    }
}
