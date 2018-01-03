using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.EntityLayer
{
    public class person
    {
        //public static string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Layer\Hotel_Management_System\Hotel_Management_System\Hotel_Management_System\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30";
        public MyHotelDBDataContext cntx = LogIn.cntx;
        public string username, password;

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
        //public string Address
        //{
        //    get { return this.address; }
        //    set { this.address = value; }
        //}
        //public string Telephone
        //{
        //    get { return this.telephone; }
        //    set { this.telephone = value; }
        //}
        public string Password
        {
            set { this.password = value; }
        }

        public virtual bool ValidateUser()
        {
            return true;
        }
        
    }
}
