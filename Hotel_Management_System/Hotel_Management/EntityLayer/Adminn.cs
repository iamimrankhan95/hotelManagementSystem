using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.EntityLayer
{
    public class Adminn:person
    {
        public int admin_id;
        public void seeRevenue()
        {
            double rev = 0;
            var allOrders = LogIn.cntx.Guests;

            foreach (var order in allOrders)
            {
                rev+= order.total;
                
            }
        }
        public void registerReceptionist(string name,string phone,string email, string pass)
        {
            Receptionist r = new Receptionist();
            r.Id = GetDataforRec() + 1;

            r.Rec_id = GetDataForRecId() + 1;
            r.Rec_name = name;
            r.Rec_phone = phone;
            r.Rec_email = email;
            r.Rec_password = pass;
            LogIn.cntx.Receptionists.InsertOnSubmit(r);
            LogIn.cntx.SubmitChanges();
        }

        int GetDataforRec()
        {
            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");
            //dataGridView1.DataSource = cntx.Persons;
            try
            {
                var s = from a in LogIn.cntx.Receptionists
                        select a.Id;
                int p = s.First();
                //txtFirstName.Text = p.ToString();
                //comboBox1.DataSource = s;
                return p;
            }
            catch (Exception ex3)
            {
                return 0;
            }
        }

        int GetDataForRecId()
        {
            MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");
            //dataGridView1.DataSource = cntx.Persons;
            try
            {
                var s = from a in cntx.Receptionists
                        select a.Rec_id;
                int p = s.First();
                //txtFirstName.Text = p.ToString();
                //comboBox1.DataSource = s;*/
                return p;
            }
            catch (Exception ex2)
            {
                return 0;
            }
        }

        int GetDataforAdmin()
        {
            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");
            //dataGridView1.DataSource = cntx.Persons;
            try
            {
                var s = from a in LogIn.cntx.Admins
                        select a.Admin_id;
                int p = s.First();
                return p;
            }
            catch (Exception ex4)
            {
                return 0;
            }
        }

        public void registerAdmin(string username,string password,int i)
        {
            Admin a = new Admin();
            a.Admin_id = GetDataforAdmin() + 1;
            a.Admin_name = username;
            a.Admin_password = password;


            LogIn.cntx.Admins.InsertOnSubmit(a);
            LogIn.cntx.SubmitChanges();
        }

        public override bool ValidateUser()
        {
            Admin a = LogIn.cntx.Admins.SingleOrDefault(x => x.Admin_name == this.username && x.Admin_password == this.password);
            if (a != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void seeDetails()
        {

        }
    }
}
