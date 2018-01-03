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
    public partial class RegistrationReceptionist : Form
    {
        Hotel_Management.EntityLayer.Adminn admin = new Hotel_Management.EntityLayer.Adminn();
        DataTable t = new DataTable();
        public RegistrationReceptionist()
        {
            InitializeComponent();            
        }
              
        private void lblRecepPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnRecepRegister_Click(object sender, EventArgs e)
        {
            admin.registerReceptionist(txtRecepName.Text, txtRecepPhone.Text, txtRecepEmail.Text, txtRecepPassword.Text);         
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }

        private void RegistrationReceptionist_Load(object sender, EventArgs e)
        {
         
        }
    }
}
