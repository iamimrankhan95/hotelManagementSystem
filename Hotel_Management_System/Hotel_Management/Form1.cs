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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomForGuest rg = new RoomForGuest();
            rg.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn li1 = new LogIn();
            li1.Show();
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn li2 = new LogIn();
            li2.Show();
        }
    }
}
