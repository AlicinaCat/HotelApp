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
    public partial class frmNewBooking : Form
    {
        public Booking Booking { get; set; }
        public Room Room { get; set; }
        public Guest Guest { get; set; }

        public frmNewBooking(int roomID, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            Booking = new Booking();

            Booking.StartDate = startDate;
            Booking.EndDate = endDate;
            Booking.RoomID = roomID;

            txtStartDate.Text = Booking.StartDate.ToShortDateString();
            txtEndDate.Text = Booking.EndDate.ToShortDateString();

            var ctx = new HotelBookingsEntities();
            Room = ctx.Rooms.Find(Booking.RoomID);

            txtRoom.Text = Room.Title;

            Booking.TotalPrice = CalculateAmount();
            txtTotalPrice.Text = Booking.TotalPrice.ToString();

            PopulateComboBox();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmNewBooking_Load(object sender, EventArgs e)
        {

        }

        private decimal CalculateAmount()
        {
            int days = (Booking.EndDate - Booking.StartDate).Days;
            decimal amount = Room.Price * days;

            return amount;
        }

        private void PopulateComboBox()
        {
            cmbExtraBeds.Items.Add(0);

            if (Room.ExtraBed == 1)
                cmbExtraBeds.Items.Add(1);
            else if (Room.ExtraBed == 2)
            {
                cmbExtraBeds.Items.Add(1);
                cmbExtraBeds.Items.Add(2);
            }

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
            }

        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            frmGuest frmGuest = new frmGuest();
            frmGuest.Show();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            using (var context = new HotelBookingsEntities())
            {
                var booking = Booking;
                {
                    booking.Time = DateTime.Now;
                    booking.GuestID = Guest.GuestID;
                };
                context.Bookings.Add(booking);

                context.SaveChanges();
            }

            Close();
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateGuest frmUpdate = new frmUpdateGuest(Guest);
            frmUpdate.Show();
        }
    }
}
