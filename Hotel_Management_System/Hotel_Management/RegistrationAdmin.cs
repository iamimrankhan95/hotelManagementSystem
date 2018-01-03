using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Hotel_Management
{
    public partial class RegistrationAdmin : Form
    {
        Hotel_Management.EntityLayer.Adminn aa = new Hotel_Management.EntityLayer.Adminn();
        DataTable t = new DataTable();
        public RegistrationAdmin()
        {
            InitializeComponent();
        }
        

        private void btnAdminRegister_Click(object sender, EventArgs e)
        {
            MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");
            aa.registerAdmin(txtAdminName.Text,txtAdminPassword.Text,LogIn.adminId);                                 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn lia = new LogIn();
            lia.Show();

        }

        private void RegistrationAdmin_Load(object sender, EventArgs e)
        {
            //GetData();
        }
    }
}
