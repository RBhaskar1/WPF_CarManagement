using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace CarManagement
{
    class Utility
    {
        static public bool validEmptyFields(Grid data)
        {
            string message = null;

            foreach(Control ctl in data.Children)
            {
                if(ctl.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)ctl;
                    string uid = tb.Uid;

                    if (uid.Contains("Price") || uid.Contains("Engine")) { try { Convert.ToDouble(tb.Text); } catch(Exception e) { message = message + "Please put in a Numeric Value for " + uid + "\n"; } }
                    else if (uid.Contains("Year") || uid.Contains("ID") || uid.Contains("Number")) { try { Convert.ToInt16(tb.Text); } catch (Exception e) { message = message + "Please put in a Numeric Value for " + uid + "\n"; } }
                    else if (tb.Text.Length == 0) { message = message + "Please enter the value for " + uid + "\n"; }
                }
            }

            if (message == null)
                return true;
            else
            {
                MessageBox.Show(message);
                return false;
            }
        }
    }
}
