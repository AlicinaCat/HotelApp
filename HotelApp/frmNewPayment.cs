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
    public partial class frmNewPayment : Form
    {
        public Booking Booking { get; set; }
        public Invoice Invoice { get; set; }

        public frmNewPayment(Booking booking)
        {
            InitializeComponent();

            Booking = booking;

            txtBookingID.Text = Booking.BookingID.ToString();
            txtTotalPrice.Text = Booking.TotalPrice.ToString();
        }



        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdPay_Click(object sender, EventArgs e)
        {
            Invoice = new Invoice();

            using (var context = new HotelBookingsEntities())
            {
                var invoice = Invoice;
                {
                    invoice.BookingID = Booking.BookingID;
                    invoice.Amount = Booking.TotalPrice;
                    invoice.Date = DateTime.Now;

                };
                context.Invoices.Add(invoice);

                context.SaveChanges();
            }

            Close();
        }
    }
}
