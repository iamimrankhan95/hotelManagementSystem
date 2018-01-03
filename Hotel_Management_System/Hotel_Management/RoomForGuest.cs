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
    public partial class RoomForGuest : Form
    {
        Hotel_Management.EntityLayer.Guestt guest = new Hotel_Management.EntityLayer.Guestt();

        public MyHotelDBDataContext cntx = LogIn.cntx;
        public RoomForGuest()
        {
            InitializeComponent();
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {

            panelSingleRoom.Visible = true;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;

            panelFor7000.Visible = false;

        }

        private void btnConfirmPresident_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestReservation gr = new GuestReservation();
            gr.Show();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = true;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;

            panelFor7000.Visible = false;
        }

        private void btnQuad_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = true;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
        }

        private void btnDelux_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = true;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;

            panelFor7000.Visible = false;
        }

        private void btnSuperDelux_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = true;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;

            panelFor7000.Visible = false;
        }

        private void btnPresidentSuit_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = true;


            panelFor7000.Visible = false;
        }

        private void RoomForGuest_Load(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }


        private void btnBackToForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f3 = new Form1();
            f3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGoForDouble_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = true;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForPrisident_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = true;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnB7000_Click(object sender, EventArgs e)
        {

            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = true;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnB6000_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = true;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnB5000_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = true;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnB4000_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = true;
            panelFor3000.Visible = false;

        }

        private void btnB3000_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = true;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForSingle4000_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = true;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForDouble4000_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = true;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = true;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForDouble5000_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = true;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForDelux5000_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = true;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForSingle_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = true;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForDelux_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = true;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForSDelux_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = true;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForQuad_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = true;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForSingleRoom6000_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = true;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForDoubleRoom6000_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = true;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForDeluxRoom6000_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = true;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForSDeluxRoom6000_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = true;
            panelQuadRoom.Visible = false;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }

        private void btnGoForQuadRoom6000_Click(object sender, EventArgs e)
        {
            panelSingleRoom.Visible = false;
            panelDoubleRoom.Visible = false;
            panelDeluxRoom.Visible = false;
            panelSDeluxRoom.Visible = false;
            panelQuadRoom.Visible = true;
            panelPresidentSuit.Visible = false;


            panelFor7000.Visible = false;
            panelFor6000.Visible = false;
            panelFor5000.Visible = false;
            panelFor4000.Visible = false;
            panelFor3000.Visible = false;
        }



        private void btn121President_Click(object sender, EventArgs e)
        {
        }

        private void btnConfirmPresident_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn122President_Click(object sender, EventArgs e)
        {
           
        }

        private void btn123President_Click(object sender, EventArgs e)
        {
        }

        private void btn124President_Click(object sender, EventArgs e)
        {
        }

        private void btnBackPresident_Click(object sender, EventArgs e)
        {
        }

        private void btn101sin_Click(object sender, EventArgs e)
        {
        }

        private void btn102sin_Click(object sender, EventArgs e)
        {
           
        }

        private void btn103sin_Click(object sender, EventArgs e)
        {
           
        }

        private void btn104sin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBackSin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnConfirmDelux_Click(object sender, EventArgs e)
        {
        }

        private void btnBackDelux_Click(object sender, EventArgs e)
        {
        }

        private void btn109Delux_Click(object sender, EventArgs e)
        {
        }

        private void btn110Delux_Click(object sender, EventArgs e)
        {
        }

        private void btn111Delux_Click(object sender, EventArgs e)
        {
        }

        private void btn112Delux_Click(object sender, EventArgs e)
        {
        }

        private void btnConfirmDouble_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBackDouble_Click(object sender, EventArgs e)
        {
        }

        private void btn105double_Click(object sender, EventArgs e)
        {
        }

        private void btn106double_Click(object sender, EventArgs e)
        {
        }

        private void btn107double_Click(object sender, EventArgs e)
        {
        }

        private void btn108double_Click(object sender, EventArgs e)
        {
           
        }

        private void btnConfirmQuad_Click(object sender, EventArgs e)
        {
        }

        private void btnBackQuad_Click(object sender, EventArgs e)
        {
        }

        private void btn117Quad_Click(object sender, EventArgs e)
        {
        }

        private void btn118Quad_Click(object sender, EventArgs e)
        {
        }

        private void btn119Quad_Click(object sender, EventArgs e)
        {
           
        }

        private void btn120Quad_Click(object sender, EventArgs e)
        {
        }

        private void btnBackSDelux_Click(object sender, EventArgs e)
        {
        }

        private void btnConfirmSDelux_Click(object sender, EventArgs e)
        {
        }

        private void btn113SDelux_Click(object sender, EventArgs e)
        {
           
        }

        private void btn114SDelux_Click(object sender, EventArgs e)
        {
        }

        private void btn115SDelux_Click_1(object sender, EventArgs e)
        {
        }

        private void btn116SDelux_Click(object sender, EventArgs e)
        {
            
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

   
        private void btn101sin_Click_1(object sender, EventArgs e)
        {
            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn101sin.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor101Sin.Text = s;
        }

        private void btn102sin_Click_1(object sender, EventArgs e)
        {
            Hotel_Management.EntityLayer.Rooomm room = new Hotel_Management.EntityLayer.Rooomm(btn102sin.Text);
            txtCheckFor102Sin.Text = room.isBooked();
        }

        private void btn103sin_Click_1(object sender, EventArgs e)
        {
            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn103sin.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor103Sin.Text = s;
        }

        private void btn104sin_Click_1(object sender, EventArgs e)
        {
            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn104sin.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor104Sin.Text = s;
        }

        private void btnBackSin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }


        private void btnConfirmSin_Click(object sender, EventArgs e)
        {
            Room s = guest.confirm(txtBookSin.Text);
            if (s!=null)
            {
                this.Hide();

                GuestReservation rg = new GuestReservation(s.Room_num, s.Room_floor, s.Room_type, s.Room_price,guest);

                rg.Show();
            }
            else
            {
                MessageBox.Show("Sorry room " + txtBookSin.Text + " is already booked.");
            }
            //RoomForGuest a = new RoomForGuest();
            //try
            //{
            //    var rfg = from m in cntx.Rooms
            //              where m.Room_num == txtBookSin.Text
            //              select m;

            //    Room s = rfg.First();
            //    if (s.Room_bookingStatus.Equals("unbooked"))
            //    {
            //        this.Hide();
            //        GuestReservation rg = new GuestReservation(s.Room_num, s.Room_floor, s.Room_type, s.Room_price);

            //        rg.Show();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Sorry room " + s.Room_num + " is already booked.");
            //    }
            //}

            //catch (Exception ex9)
            //{
            //    MessageBox.Show("Invalid RoomNO");
            //}

        }

        private void btn105double_Click_1(object sender, EventArgs e)
        {

            // cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn105double.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor105Dou.Text = s;
        }

        private void btn106double_Click_1(object sender, EventArgs e)
        {

           // MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn106double.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor106Dou.Text = s;
        }

        private void btn107double_Click_1(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn107double.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor107Dou.Text = s;
        }

        private void btn108double_Click_1(object sender, EventArgs e)
        {
            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn108double.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor108Dou.Text = s;
        }

        private void btnConfirmDouble_Click_1(object sender, EventArgs e)
        {
            Room s = guest.confirm(txtBookDouble.Text);
            if (s != null)
            {
                this.Hide();

                GuestReservation rg = new GuestReservation(s.Room_num, s.Room_floor, s.Room_type, s.Room_price,guest);

                rg.Show();
            }
            else
            {
                MessageBox.Show("Sorry room " + txtBookDouble.Text + " is already booked.");
            }

        }

        private void btnBackDouble_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void btn109Delux_Click_1(object sender, EventArgs e)
        {
            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn109Delux.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor109Del.Text = s;
        }

        private void btn110Delux_Click_1(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn110Delux.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor110Del.Text = s;
        }

        private void btn111Delux_Click_1(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn111Delux.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor111Del.Text = s;
        }

        private void btn112Delux_Click_1(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn112Delux.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor112Del.Text = s;
        }

        private void btnConfirmDelux_Click_1(object sender, EventArgs e)
        {
            Room s = guest.confirm(txtBookDelux.Text);
            if (s != null)
            {
                this.Hide();

                GuestReservation rg = new GuestReservation(s.Room_num, s.Room_floor, s.Room_type, s.Room_price,guest);

                rg.Show();
            }
            else
            {
                MessageBox.Show("Sorry room " + txtBookDelux.Text + " is already booked.");
            }

        }

        private void btnBackDelux_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void btn113SDelux_Click_1(object sender, EventArgs e)
        {
            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn113SDelux.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor113SDel.Text = s;
        }

        private void btn114SDelux_Click_1(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn114SDelux.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor114SDel.Text = s;
        }

        private void btn115SDelux_Click(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn115SDelux.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor115SDel.Text = s;
        }

        private void btn116SDelux_Click_1(object sender, EventArgs e)
        {
            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn116SDelux.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor116SDel.Text = s;
        }

        private void btnConfirmSDelux_Click_1(object sender, EventArgs e)
        {
            Room s = guest.confirm(txtBookSDelux.Text);
            if (s != null)
            {
                this.Hide();

                GuestReservation rg = new GuestReservation(s.Room_num, s.Room_floor, s.Room_type, s.Room_price,guest);

                rg.Show();
            }
            else
            {
                MessageBox.Show("Sorry room " + txtBookSDelux.Text + " is already booked.");
            }
        }

        private void btnBackSDelux_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void btn117Quad_Click_1(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn117Quad.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor117Quad.Text = s;
        }

        private void btn118Quad_Click_1(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn118Quad.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor118Quad.Text = s;
        }

        private void btn119Quad_Click_1(object sender, EventArgs e)
        {
            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn119Quad.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor119Quad.Text = s;
        }

        private void btn120Quad_Click_1(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn120Quad.Text
                      select m.Room_bookingStatus;

            string s = rfg.First();
            txtCheckFor120Quad.Text = s;
        }

        private void btnConfirmQuad_Click_1(object sender, EventArgs e)
        {
            Room s = guest.confirm(txtBookQuad.Text);
            if (s != null)
            {
                this.Hide();

                GuestReservation rg = new GuestReservation(s.Room_num, s.Room_floor, s.Room_type, s.Room_price,guest);

                rg.Show();
            }
            else
            {
                MessageBox.Show("Sorry room " + txtBookQuad.Text + " is already booked.");
            }
        }

        private void btnBackQuad_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void btn121President_Click_1(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn121President.Text
                      select m.Room_bookingStatus;
            //txtCheckFor121Pre.Text= 
            string s = rfg.First();
            txtCheckFor121Pre.Text = s;
        }

        private void btn122President_Click_1(object sender, EventArgs e)
        {
            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn122President.Text
                      select m.Room_bookingStatus;
            //txtCheckFor121Pre.Text= 
            string s = rfg.First();
            txtCheckFor122Pre.Text = s;
        }

        private void btn123President_Click_1(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn123President.Text
                      select m.Room_bookingStatus;
            //txtCheckFor121Pre.Text= 
            string s = rfg.First();
            txtCheckFor123Pre.Text = s;
        }

        private void btn124President_Click_1(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            RoomForGuest a = new RoomForGuest();

            var rfg = from m in cntx.Rooms
                      where m.Room_num == btn124President.Text
                      select m.Room_bookingStatus;
            //txtCheckFor121Pre.Text= 
            string s = rfg.First();
            txtCheckFor124Pre.Text = s;
        }

        private void btnConfirmPresident_Click_2(object sender, EventArgs e)
        {
            Room s = guest.confirm(txtBookPresident.Text);
            if (s != null)
            {
                this.Hide();

                GuestReservation rg = new GuestReservation(s.Room_num, s.Room_floor, s.Room_type, s.Room_price,guest);

                rg.Show();
            }
            else
            {
                MessageBox.Show("Sorry room " + txtBookPresident.Text + " is already booked.");
            }
        }

        private void btnBackPresident_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }

}