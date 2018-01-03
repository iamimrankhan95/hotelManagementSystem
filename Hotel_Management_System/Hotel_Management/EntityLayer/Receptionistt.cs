using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.EntityLayer
{
    partial class Receptionistt:person
    {
        public static int i = 0;
        public string email, phone, recep_id;
        public void print(Guest r,double totalBill,string confirmedBy)
        {
            string date = (DateTime.Now).ToString();
            string path = string.Format("Memo of {0}.txt",++i);
            StreamWriter SaveFile = new StreamWriter(path);
            SaveFile.WriteLine(DateTime.Now);

            SaveFile.WriteLine("name: " + r.Guest_firstName.ToString() + "\n " + "room: " + r.Guest_roomNo.ToString() + "\n days: " + r.Guest_stayingDay.ToString()+ "\n confirmed by:" + confirmedBy);

            SaveFile.WriteLine("\n\nTotal : " + totalBill);
            SaveFile.Close();
            r.Guest_payingStatus = "paid";
            LogIn.cntx.SubmitChanges();
            MessageBox.Show("Printed Successfully");
        }

        public bool confirm(Guest g,Room r)
        {
            if (g.Guest_confirmationStatus.Equals("confirmed"))
            {
                return false;
            }
            else
            {
                r.Room_bookingStatus = "booked";
                g.Guest_confirmationStatus = "confirmed";
                g.Guest_confirmByReceptionist = Convert.ToString(LogIn.loggedIN);
                LogIn.cntx.SubmitChanges();
                return true;
            }
            
        }

        public bool deny(Guest g)
        {
            if (g.Guest_payingStatus.Equals("paid"))
            {
                return false;
            }
            else
            {
                g.Guest_confirmationStatus = "denied";
                g.Guest_confirmByReceptionist = Convert.ToString(LogIn.loggedIN);
                LogIn.cntx.SubmitChanges();
                return true;
            }
            
        }

        public override bool ValidateUser()// polymorphism
        {
            Receptionist r=cntx.Receptionists.SingleOrDefault(x => x.Rec_name == this.username && x.Rec_password == this.password);
            if (r!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }

}
