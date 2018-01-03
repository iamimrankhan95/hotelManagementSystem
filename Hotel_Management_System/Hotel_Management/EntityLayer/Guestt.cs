using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.EntityLayer
{
    public class Guestt
    {
        public int Guest_id ,Guest_quantity ,Guest_stayingDay;
        public string Guest_firstName, Guest_lastName, Guest_birthday, Guest_gender, Guest_phone, Guest_email, Guest_address, Guest_nationality, Guest_national_id, Guest_roomType, Guest_roomFloor, Guest_roomNo, Guest_checkIn, Guest_checkOut, Guest_confirmationStatus, Guest_payingStatus, Guest_confirmByReceptionist;
        public Room confirm(string txtBookSin)
        {
            //RoomForGuest a = new RoomForGuest();
            try
            {
                var rfg = from m in LogIn.cntx.Rooms
                          where m.Room_num == txtBookSin
                          select m;

                Room s = rfg.First();
                if (s.Room_bookingStatus.Equals("unbooked"))
                {
                    return s;
                    

                }
                else
                {
                    
                    return null;
                }
            }

            catch (Exception ex9)
            {
                MessageBox.Show("Invalid RoomNO");
                return null;
            }
        }
        public void submit(Guest g,string txtFirstName, string txtLast, DateTime dateTimePickerBirthday, string txtPhoneNumber, string txtEmail, string txtAddress, string txtNationality,
          string txtNationalID, int txtGuestNum, string txtRoomType, string txtFloor, string txtRoomNum, DateTime dateTimePickerCheckIn, 
          DateTime dateTimePickerCheckOut,int stayingDay)
        {
            TimeSpan ts = dateTimePickerCheckOut - dateTimePickerCheckIn;
            g.Guest_id = GetData() + 1;
            g.Guest_firstName = txtFirstName;
            g.Guest_lastName = txtLast; ;
            g.Guest_birthday = dateTimePickerBirthday;
            g.Guest_phone = txtPhoneNumber;
            g.Guest_email = txtEmail;
            g.Guest_address = txtAddress;
            g.Guest_nationality = txtNationality;
            g.Guest_national_id = txtNationalID;
            g.Guest_quantity = txtGuestNum;
            g.Guest_roomType = txtRoomType;
            g.Guest_roomFloor = txtFloor;
            g.Guest_roomNo = txtRoomNum;
            g.Guest_checkIn = dateTimePickerCheckIn;
            g.Guest_checkOut = dateTimePickerCheckOut;
            g.Guest_stayingDay = stayingDay;
            g.Guest_confirmationStatus = "pending";
            g.Guest_payingStatus = "pending";
            g.Guest_confirmByReceptionist = null;
            LogIn.cntx.Guests.InsertOnSubmit(g);
            LogIn.cntx.SubmitChanges();

        }

        int GetData()
        {
            //MyHotelDBDataContext cntx = new MyHotelDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Desktop\Hotel_Management_System\Hotel_Management\Hotel_Info.mdf;Integrated Security=True;Connect Timeout=30");
            //dataGridView1.DataSource = cntx.Persons;

            var s = from a in LogIn.cntx.Guests
                    select a.Guest_id;
            int p = s.First();
            //txtFirstName.Text = p.ToString();
            //comboBox1.DataSource = s;*/
            return p;
        }
    }
}
