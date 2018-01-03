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
    public partial class LogIn : Form
    {
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Imran Ahmed Khan\Layer\Hotel_Management_System\Hotel_Management_System\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30";
        public static MyHotelDBDataContext cntx = new MyHotelDBDataContext(connectionString);
        public static string loggedIN;
        public static int adminId;

        public LogIn()
        {
            InitializeComponent();
            txtPasswordLogin.KeyUp+=txtPasswordLogin_KeyUp;
        }

        private void txtPasswordLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

                Hotel_Management.EntityLayer.Receptionistt p = new Hotel_Management.EntityLayer.Receptionistt();
                p.username = txtUserNameLogin.Text; p.password = txtPasswordLogin.Text;

                Hotel_Management.EntityLayer.Adminn a = new Hotel_Management.EntityLayer.Adminn();
                a.username = txtUserNameLogin.Text; a.password = txtPasswordLogin.Text;

          
                if (a.ValidateUser())
                {
                    //MessageBox.Show("Success to Admin Login!!!");
                    //txtUserNameLogin.Text = txtPasswordLogin.Text = string.Empty;
                    adminId = a.admin_id; 
                    loggedIN = a.username;
                    this.Hide();
                    AdminPanel ap = new AdminPanel();
                    ap.Show();
                }
                else if (p.ValidateUser())
                {
                    //MessageBox.Show("Success to Receptionist Login!!!");
                    //txtUserNameLogin.Text = txtPasswordLogin.Text = string.Empty;
                   
                     loggedIN = p.username;
                    this.Hide();
                    RequestForReservation rfr = new RequestForReservation();
                    rfr.Show();
                }

                else
                {
                    MessageBox.Show("Invalid!!!! Please Enter The Correct User Name And Password!!!!");
                }
          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f4 = new Form1();
            f4.Show();
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrationAR_Click(object sender, EventArgs e)
        {
            //panelForSelectRegistration.Visible = true;
        }

        private void btnForRegistrationSelectReceptionist_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationReceptionist rr = new RegistrationReceptionist();
            rr.Show();

        }

        private void btnForRegistrationSelectAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationAdmin ra = new RegistrationAdmin();
            ra.Show();
        }

        private void txtPasswordLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
