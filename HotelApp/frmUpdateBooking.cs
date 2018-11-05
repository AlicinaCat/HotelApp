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
    public partial class frmUpdateBooking : Form
    {
        public Booking Booking { get; set; }

        public frmUpdateBooking(Booking booking)
        {
            InitializeComponent();

            Booking = booking;

            dtpStartDate.Value = Booking.StartDate;
            dtpEndDate.Value = Booking.EndDate;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            using (var context = new HotelBookingsEntities())
            {
                var booking = context.Bookings.Find(Booking.BookingID);
                booking.StartDate = dtpStartDate.Value.Date;
                booking.EndDate = dtpEndDate.Value.Date;
                booking.TotalPrice = CalculateAmount();
                context.SaveChanges();
            }

            MessageBox.Show("Booking dates updated.");
            Close();
        }

        private decimal CalculateAmount()
        {
            decimal amount; 

            using (var context = new HotelBookingsEntities())
            {
                var room = context.Rooms.Find(Booking.RoomID);
                int days = (Booking.EndDate - Booking.StartDate).Days;
                amount = room.Price * days;
            }

            return amount;
        }
    }
}
