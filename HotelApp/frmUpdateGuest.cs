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
    public partial class frmUpdateGuest : Form
    {
        public Guest Guest { get; set; }

        public frmUpdateGuest(Guest guest)
        {
            InitializeComponent();

            Guest = guest;

            txtName.Text = Guest.Name;
            txtEmail.Text = Guest.Email;
            txtPhone.Text = Guest.Phone;
        }

        private void frmUpdateGuest_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            using (var context = new HotelBookingsEntities())
            {
                var guest = (from g in context.Guests
                            where g.GuestID == Guest.GuestID
                            select g).SingleOrDefault();

                guest.Name = txtName.Text;
                guest.Email = txtEmail.Text;
                guest.Phone = txtPhone.Text;
                context.SaveChanges();
            }

            Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
