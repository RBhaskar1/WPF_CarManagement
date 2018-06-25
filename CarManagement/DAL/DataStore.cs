using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DataStore
    {
        public static List<Tuple<int, int, int>> idUpdated = new List<Tuple<int,int,int>>();
        
        public static string LoginUser(string usr, string pwd)
        {
            Con ctx = new Con();
             return ctx.Employees.Where(e => e.Username == usr && e.Password == pwd).FirstOrDefault().Role;
        }

        public static Tuple<bool,string> AddObject(Object c,string tablename)
        {
            try
            {
                Con ctx = new Con();
                switch (tablename)
                {
                    case "CarFeatures":
                        ctx.CarFeatures.Add((CarFeature)c);
                        break;
                    case "CarModels":
                        ctx.CarModels.Add((CarModel)c);
                        break;
                    case "IndividualCars":
                        ctx.IndividualCars.Add((IndividualCar)c);
                        break;
                    case "FeaturesOnCar":
                        ctx.FeaturesOnCars.Add((FeaturesOnCar)c);
                        break;
                }
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                if (e.InnerException != null || e.InnerException.ToString().Contains("null"))
                    return new Tuple<bool, string>(false,e.InnerException.ToString());
                else
                    return new Tuple<bool, string>(false, e.ToString());
            }

            return new Tuple<bool, string>(true,"success");
        }

        public static bool AddObject(Object carFeature, Object featuresOnCar)
        {
            try
            {
                Con ctx = new Con();
                ctx.CarFeatures.Add((CarFeature)carFeature);
                ctx.SaveChanges();
                ctx.FeaturesOnCars.Add((FeaturesOnCar)featuresOnCar);
                ctx.SaveChanges();
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }

        public static List<IndividualCar> GetAvailableCars()
        {
            Con ctx = new Con();
            return ctx.IndividualCars.Where(c => c.Status == "Available").ToList();
        }

        public static List<CarDetailsViewModel> SearchCarByModel(string model)
        {
            Con ctx = new Con();
            return ctx.Database.SqlQuery<CarDetailsViewModel>("SELECT * FROM IndividualCar c INNER JOIN FeaturesOnCars fc ON c.CarID = fc.Car_For_Sale_ID INNER JOIN CarFeature f ON f.FeatureID = fc.Car_Feature_ID INNER JOIN CarModel m ON m.ModelID = c.Model_ID WHERE m.Model = " + "'" + model + "'").ToList();
        }

        public static int GetFeatureID(string feature)
        {
            try
            {
                Con ctx = new Con();
                return ctx.CarFeatures.Where(f => f.Car_Feature_Description.Contains(feature)).FirstOrDefault().FeatureID;
            }
            catch
            {
                return -1;
            }
        }

        public static bool UpdateObjects(CarDetailsViewModel cvw)
        {
            //if (!idUpdated.Contains(new Tuple<int, int, int>(cvw.ModelID, cvw.CarID, cvw.FeatureID)))
            //{
                try
                {
                    Con ctx = new Con();

                    var ModelUpdate = ctx.CarModels.Where(m => m.ModelID == cvw.ModelID).FirstOrDefault();
                    ModelUpdate.EngineSize = cvw.EngineSize;
                    ModelUpdate.NumberOfSeats = cvw.NumberOfSeats;

                    var CarUpdate = ctx.IndividualCars.Where(c => c.CarID == cvw.CarID).FirstOrDefault();
                    CarUpdate.Colour = cvw.Colour;
                    CarUpdate.Current_Mileage = cvw.Current_Mileage;
                    CarUpdate.Status = cvw.Status;
                    CarUpdate.Transmission = cvw.Transmission;

                    var FeatureUpdate = ctx.CarFeatures.Where(f => f.FeatureID == cvw.FeatureID).FirstOrDefault();
                    FeatureUpdate.Car_Feature_Description = cvw.Car_Feature_Description;

                    ctx.SaveChanges();
                    idUpdated.Add(new Tuple<int, int, int>(cvw.ModelID, cvw.CarID, cvw.FeatureID));
                    return true;
                }
                catch { return false; }
            //}
            //else
            //    return true;
        }
    }
}