using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class frmMain : Form
    {
        public List<Room> RoomList { get; set; }

        public frmMain()
        {
            InitializeComponent();

            using (var ctx = new HotelBookingsEntities())
            {

                RoomList = ctx.Rooms.ToList<Room>();
            }


            lstRooms.DataSource = RoomList;
            lstRooms.DisplayMember = "Title";
            lstRooms.ValueMember = "RoomID";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Room room = (Room)lstRooms.SelectedItem;

            txtTitle.Text = room.Title;
            txtExtraBeds.Text = room.ExtraBed.ToString();
            txtPrice.Text = room.Price.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room room = (Room)lstRooms.SelectedItem;

            frmNewBooking frmNewBooking = new frmNewBooking(room.RoomID, dtpStartDate.Value, dtpEndDate.Value);

            frmNewBooking.Show();
        }

        private void FindAvailableRooms()       //???
        {
            List<Room> availableRooms = new List<Room>();
            bool isAvailable = true;

            using (var ctx = new HotelBookingsEntities())
            {
                foreach (var room in ctx.Rooms)
                {
                    foreach (var booking in room.Bookings)
                    {
                        if (booking.StartDate >= dtpStartDate.Value.Date &&
                            booking.EndDate <= dtpEndDate.Value.Date)
                        {
                            isAvailable = false;
                        }

                        if (isAvailable)
                        {
                            availableRooms.Add(room);
                        }
                        else availableRooms.Remove(room);
                    }
                }

                lstRooms.DataSource = availableRooms;
                lstRooms.DisplayMember = "Title";
                lstRooms.ValueMember = "RoomID";
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            //FindAvailableRooms();
        }
    }
}
