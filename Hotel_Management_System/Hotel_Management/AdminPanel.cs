using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class AdminPanel : Form
    {
        //Hotel_Management.EntityLayer.Adminn admin = new Hotel_Management.EntityLayer.Adminn();
        MyHotelDBDataContext cntx = LogIn.cntx;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnBackToForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void lblReceptionistDetailsToAdmin_Click(object sender, EventArgs e)
        {
            panelReceptionistDetailsToAdmin.Visible = true;
            panelUserDetailsToAdmin.Visible = false;
        }

        private void btnGuestInfoToAdmin_Click(object sender, EventArgs e)
        {

            panelUserDetailsToAdmin.Visible = true;
            panelReceptionistDetailsToAdmin.Visible = false;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            panelUserDetailsToAdmin.Visible = false;
            panelReceptionistDetailsToAdmin.Visible = false;
            Hotel_Management.EntityLayer.Adminn admin = new Hotel_Management.EntityLayer.Adminn();
            admin.seeRevenue();
        }

        private void btnAddNewAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationAdmin ra = new RegistrationAdmin();
            ra.Show();
        }

        private void btnAddNewReceptionist_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationReceptionist ra = new RegistrationReceptionist();
            ra.Show();
        }

        private void btnSearchReceptionistByAdmin_Click(object sender, EventArgs e)
        {
            if (txtReceptionistIdByAdmin.Text!= "")
            {
                var str = from a in cntx.Receptionists
                          where a.Id == int.Parse(txtReceptionistIdByAdmin.Text)
                          select a;
                dataGridViewSelectedUserDetails.DataSource = str;
            }
            else
            {
                MessageBox.Show("fill with a valid value");
            }
                

        }

        private void btnSearchUserDetailsByAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                var str = from a in cntx.Guests
                          where a.Guest_id == int.Parse(txtUserDetailsByAdmin.Text)
                          select a;
                Guest g = str.First();
                dataGridViewUserDetailsToAdmin.DataSource = str;

            }
            catch (Exception f)
            {
                MessageBox.Show("Invalid Guest Id!!! Search For Valid ID!!!");
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
                var str = from a in cntx.Guests
                          select a;
                dataGridViewUserDetailsToAdmin.DataSource = str;
        }

        private void btnViewAllReceptionistDetails_Click(object sender, EventArgs e)
        {
                var str = from a in LogIn.cntx.Receptionists
                              select a;
                dataGridViewSelectedUserDetails.DataSource = str;

        }

        private void txtReceptionistIdByAdmin_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
