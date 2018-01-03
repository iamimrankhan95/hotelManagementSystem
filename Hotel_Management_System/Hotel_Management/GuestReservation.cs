using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.DateTime;
using System.Data.SqlClient;

namespace Hotel_Management
{
    public partial class GuestReservation : Form
    {
        Hotel_Management.EntityLayer.Guestt guest = new Hotel_Management.EntityLayer.Guestt();
        public MyHotelDBDataContext cntx = LogIn.cntx;
        DataTable t = new DataTable();
        public GuestReservation()
        {
            InitializeComponent();
           
            
        }
        public GuestReservation(string roomno,string floor,string roomtype,int roomprice, Hotel_Management.EntityLayer.Guestt guest )
        {
            InitializeComponent();
            this.txtRoomNum.Text = roomno;
            this.txtRoomType.Text = roomtype;
            this.txtFloor.Text = floor;
            this.txtRoomPrice.Text = Convert.ToString(roomprice);
            this.guest = guest;
            
            
        }



        

        private void button1_Click(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");
            
            
            try
            {
                var str = from a in cntx.Guests
                          where a.Guest_id == int.Parse(txtSearchReservation.Text)
                          select a;
                Guest g = str.First();

                txtFirstName.Text = g.Guest_firstName;
                txtLast.Text = g.Guest_lastName;
                dateTimePickerBirthday.Value = (DateTime)g.Guest_birthday;
                if (g.Guest_gender == "MALE")
                    radioButtonMale.Checked = true;
                else
                    radioButtonFemale.Checked = true;
                txtPhoneNumber.Text = g.Guest_phone;
                txtEmail.Text = g.Guest_email;
                txtAddress.Text = g.Guest_address;
                txtNationality.Text = g.Guest_nationality;
                txtNationalID.Text = g.Guest_national_id;
                txtGuestNum.Text = Convert.ToString(g.Guest_quantity);
                txtRoomType.Text = g.Guest_roomType;
                txtFloor.Text = g.Guest_roomFloor;
                txtRoomNum.Text = g.Guest_roomNo;
                dateTimePickerCheckIn.Value = (DateTime)g.Guest_checkIn;
                dateTimePickerCheckOut.Value = (DateTime)g.Guest_checkOut;
                txtStayingDay.Text = Convert.ToString(g.Guest_stayingDay);

            }
            catch(Exception f)
            {
                MessageBox.Show("invalid id");
            }

           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomForGuest rg = new RoomForGuest();
            rg.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            Guest g = new Guest();
            
            

            if (radioButtonFemale.Checked == true && radioButtonMale.Checked == false)
            {
                g.Guest_gender = radioButtonFemale.Text;
               
            }
            else
            {
                g.Guest_gender = radioButtonMale.Text;
            }
            guest.submit(g, txtFirstName.Text, txtLast.Text, dateTimePickerBirthday.Value, txtPhoneNumber.Text, txtEmail.Text,
                txtAddress.Text, txtNationality.Text, txtNationalID.Text, int.Parse(txtGuestNum.Text), txtRoomType.Text,
                txtFloor.Text, txtRoomNum.Text, dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value, int.Parse(txtStayingDay.Text));
            //g.Guest_id = GetData()+1;
            //g.Guest_firstName = txtFirstName.Text;
            //g.Guest_lastName = txtLast.Text; ;
            //g.Guest_birthday = dateTimePickerBirthday.Value;
            //g.Guest_phone = txtPhoneNumber.Text;
            //g.Guest_email = txtEmail.Text;
            //g.Guest_address = txtAddress.Text;
            //g.Guest_nationality = txtNationality.Text;
            //g.Guest_national_id = txtNationalID.Text;
            //g.Guest_quantity = int.Parse(txtGuestNum.Text);
            //g.Guest_roomType = txtRoomType.Text;
            //g.Guest_roomFloor = txtFloor.Text;
            //g.Guest_roomNo = txtRoomNum.Text;
            //g.Guest_checkIn = dateTimePickerCheckIn.Value;
            //g.Guest_checkOut = dateTimePickerCheckOut.Value;
            //g.Guest_stayingDay = int.Parse(txtStayingDay.Text);
            //g.Guest_confirmationStatus = "pending";
            //g.Guest_payingStatus = "pending";
            //g.Guest_confirmByReceptionist = null;
            //cntx.Guests.InsertOnSubmit(g);
            //cntx.SubmitChanges();
        }

        private void dateTimePickerCheckOut_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = dateTimePickerCheckOut.Value - dateTimePickerCheckIn.Value;
            txtStayingDay.Text=(ts.TotalDays).ToString();
        }

        private void btnUpdateReservation_Click(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                var str = from a in cntx.Guests
                          where a.Guest_id == int.Parse(txtSearchReservation.Text)
                          select a;

                Guest g = str.First();
                // g.Guest_id = 15;
                g.Guest_firstName = txtFirstName.Text;
                g.Guest_lastName = txtLast.Text;
                g.Guest_birthday = dateTimePickerBirthday.Value;
                if (radioButtonFemale.Checked == true && radioButtonMale.Checked == false)
                {
                    // radioButtonFemale.Text = "FEMALE";
                    g.Guest_gender = radioButtonFemale.Text;

                }
                else
                {
                    // radioButtonMale.Text = "MALE";
                    g.Guest_gender = radioButtonMale.Text;
                }

                g.Guest_phone = txtPhoneNumber.Text;
                g.Guest_email = txtEmail.Text;
                g.Guest_address = txtAddress.Text;
                g.Guest_nationality = txtNationality.Text;
                g.Guest_national_id = txtNationalID.Text;
                g.Guest_quantity = int.Parse(txtGuestNum.Text);
                g.Guest_roomType = txtRoomType.Text;
                g.Guest_roomFloor = txtFloor.Text;
                g.Guest_roomNo = txtRoomNum.Text;
                g.Guest_checkIn = dateTimePickerCheckIn.Value;
                g.Guest_checkOut = dateTimePickerCheckOut.Value;
                g.Guest_stayingDay = int.Parse(txtStayingDay.Text);
                g.Guest_confirmationStatus = "pending";
                g.Guest_payingStatus = "pending";
                g.Guest_confirmByReceptionist = null;
                //cntx.Guests.InsertOnSubmit(g);
                cntx.SubmitChanges();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Search First");
            }

        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {

            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                var str = from a in cntx.Guests
                          where a.Guest_id == int.Parse(txtSearchReservation.Text)
                          select a;

                Guest g = str.First();
                cntx.Guests.DeleteOnSubmit(g);
                cntx.SubmitChanges();

            }

            catch (Exception ex1)
            {
                MessageBox.Show("Invalid ID!!! Search Existing ID !!!");
            }
            
        }

        private void GuestReservation_Load(object sender, EventArgs e)
        {
            
        }

        private void GuestReservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnFinalizeBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }

        public void txtRoomNum_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtRoomType_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtFloor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStayingDay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
