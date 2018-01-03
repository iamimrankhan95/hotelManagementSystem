using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class RequestForReservation : Form
    {
        //public static string connectionString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Hotel_Management_System\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30";
        public MyHotelDBDataContext cntx = LogIn.cntx;
        public int roomPrince;
        public int noOfGuest;
        public double totalBill;
        public string confirmedBy;
        public Room room; Guest guest;
        Hotel_Management.EntityLayer.Receptionistt receptionist = new Hotel_Management.EntityLayer.Receptionistt();
        public RequestForReservation()
        {
            InitializeComponent();
        }

        private void btnBackToForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void btnBookingDetails_Click(object sender, EventArgs e)
        {

            panelGuestDetailsToRecep.Visible = true;
            panelFinalizeBill.Visible = false;
             var str = from a in cntx.Guests
                          //where a.Guest_id == int.Parse(txtUserIdFromRecep.Text)
                          select a;
                //Guest r = str.First();
                dataGridViewSelectedUserDetails.DataSource = str;
            
            
        }

        private void btnPaymentBill_Click(object sender, EventArgs e)
        {
            
            panelFinalizeBill.Visible = true;
            panelGuestDetailsToRecep.Visible = false;
        }

        private void RequestForReservation_Load(object sender, EventArgs e)
        {
            panelGuestDetailsToRecep.Visible = false;
            panelFinalizeBill.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           
        }

        private void btnConfirmByRecep_Click(object sender, EventArgs e)
        {
            
            
            if (receptionist.confirm(guest, room))
            {
                panelFinalizeBill.Visible = true;
                txtRoomPrice.Text = Convert.ToString(roomPrince);
                txtNoOfGuest.Text = Convert.ToString(noOfGuest);
                txtTotalBill.Text = Convert.ToString(totalBill);
                txtConfirmedByReceptionistID.Text = confirmedBy;
            }
            else
            {
                MessageBox.Show("Already Confirmed");
            }
            //t.Room_bookingStatus = "booked";
            //r.Guest_confirmationStatus = "confirmed";
            //r.Guest_confirmByReceptionist =Convert.ToString( LogIn.loggedIN);
            //cntx.SubmitChanges();
                

        }

        private void btnPrepareBill_Click(object sender, EventArgs e)
        {
            ///
            receptionist.print(guest, totalBill, guest.Guest_confirmByReceptionist);
        }

        private void btnDenyByRecep_Click(object sender, EventArgs e)
        {
            
            if (receptionist.deny(guest))
            {

            }
            else
            {
                MessageBox.Show("already paid");
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }

        private void txtUserIdFromRecep_TextChanged(object sender, EventArgs e)
        {
            try
            {


                var str = from a in cntx.Guests
                          where a.Guest_id == int.Parse(txtUserIdFromRecep.Text)
                          select a;
                guest = str.First();
                dataGridViewSelectedUserDetails.DataSource = str;

                room = cntx.Rooms.SingleOrDefault(x => x.Room_num == guest.Guest_roomNo);
                this.roomPrince = room.Room_price;
                this.noOfGuest = guest.Guest_stayingDay;
                this.totalBill = guest.Guest_stayingDay * room.Room_price;
                this.confirmedBy = LogIn.loggedIN;

                
 
            }
            catch (Exception f)
            {
            }
            
        }
    }
}
