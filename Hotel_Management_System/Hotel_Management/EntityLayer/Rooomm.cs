using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.EntityLayer
{
     class Rooomm
    {
        int Room_id;
        private string Room_num, Room_type, Room_floor, Room_price, Room_bookingStatus;
        private string text;

        public Rooomm(string text)
        {
            this.Room_num = text;
        }

        public string isBooked()
        {
            var rfg = from m in LogIn.cntx.Rooms
                      where m.Room_num == this.Room_num
                      select m.Room_bookingStatus;

            string s = rfg.First();
            return s;
        }
    }
}
