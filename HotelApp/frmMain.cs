﻿using System;
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
        public List<Booking> Bookings { get; set; }

        public frmMain()
        {
            InitializeComponent();

            using (var ctx = new HotelBookingsEntities())
            {

                RoomList = ctx.Rooms.ToList<Room>();
            }

            using (var ctx = new HotelBookingsEntities())
            {

                Bookings = ctx.Bookings.ToList<Booking>();
            }




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

        public void FindAvailableRooms()     
        {
            List<Room> availableRooms = new List<Room>();

            foreach (var room in RoomList.ToList())
            {
                DateTime checkIn = dtpStartDate.Value.Date;
                DateTime checkOut = dtpEndDate.Value.Date;

                var query = from b in Bookings
                            where (checkIn <= b.EndDate.Date && checkIn >= b.StartDate.Date ||
                            b.StartDate.Date <= checkOut && b.StartDate.Date >= checkIn) && b.RoomID == room.RoomID
                            select b;

                if (query.Count() == 0)
                {
                    availableRooms.Add(room);
                }
            }

            lstRooms.DataSource = availableRooms;
            lstRooms.DisplayMember = "Title";
            lstRooms.ValueMember = "RoomID";
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            FindAvailableRooms();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmGuestProfile frmGuestProfile = new frmGuestProfile();
            frmGuestProfile.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
