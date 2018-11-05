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
    public partial class frmGuestProfile : Form
    {
        public Guest Guest { get; set; }
        public List<Booking> Bookings { get; set; }

        public frmGuestProfile()
        {
            InitializeComponent();
        }

        private void cmdLogIn_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == null || txtEmail.Text == "")
                MessageBox.Show("Please type in your email address");
            else
            {
                var ctx = new HotelBookingsEntities();
                Guest = (from g in ctx.Guests
                         where g.Email == txtEmail.Text
                         select g).SingleOrDefault();

                txtGuestID.Text = Guest.GuestID.ToString();
                txtName.Text = Guest.Name;
                txtPhone.Text = Guest.Phone;

                LoadBookings();
            }

        }

        private void cmdRegister_Click_1(object sender, EventArgs e)
        {
            frmGuest frmGuest = new frmGuest();
            frmGuest.Show();
        }

        private void cmdUpdate_Click_1(object sender, EventArgs e)
        {
            frmUpdateGuest frmUpdate = new frmUpdateGuest(Guest);
            frmUpdate.Show();
        }

        private void lstBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Booking booking = (Booking)lstBookings.SelectedValue;

            txtRoomTitle.Text = booking.RoomID.ToString();
            txtStartDate.Text = booking.StartDate.Date.ToString();
            txtEndDate.Text = booking.EndDate.Date.ToString();
            txtPrice.Text = booking.TotalPrice.ToString();

            if (FindPayment())
                txtInvoiceID.Text = "Paid";
            else
                txtInvoiceID.Text = "Unpaid";

        }

        private void LoadBookings()
        {

            using (var ctx = new HotelBookingsEntities())
            {
                Bookings = ctx.Bookings.ToList<Booking>();
            }

            var query = from b in Bookings
                        where b.GuestID == Guest.GuestID
                        select b;

            Bookings = query.ToList();

            lstBookings.DataSource = Bookings;
            lstBookings.DisplayMember = "Time";
            lstBookings.ValueMember = "BookingID";
        }

        private bool FindPayment()
        {
            bool isPaid = false;
            Booking booking = (Booking)lstBookings.SelectedItem;

            using (var ctx = new HotelBookingsEntities())
            {
                var query = (from i in ctx.Invoices
                            where i.BookingID == booking.BookingID
                            select i).SingleOrDefault();

                if (query == null)
                    return isPaid;
                else
                    return isPaid = true;
            }
        }

        private void cmdUpdateeBooking_Click(object sender, EventArgs e)
        {
            Booking booking = (Booking)lstBookings.SelectedItem;

            frmUpdateBooking frmUpdateBooking = new frmUpdateBooking(booking);
            frmUpdateBooking.Show();
        }

        private void cmdDeleteBooking_Click(object sender, EventArgs e)
        {
            Booking selectedBooking = (Booking)lstBookings.SelectedItem;

            using (var context = new HotelBookingsEntities())
            {
                var booking = (from b in context.Bookings
                               where b.BookingID == selectedBooking.BookingID
                               select b).SingleOrDefault();

                context.Invoices.RemoveRange(booking.Invoices);
                context.Bookings.Remove(booking);

                context.SaveChanges();
            }

            MessageBox.Show("Booking cancelled.");
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}
