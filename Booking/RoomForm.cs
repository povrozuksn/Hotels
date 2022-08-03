using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public partial class RoomForm : Form
    {
        public RoomForm(string HotelName, string RoomName)
        {
            InitializeComponent();

            Text = HotelName + ": " + RoomName;
            label1.Text = HotelName;
            label5.Text = RoomName;

            if (RoomName == "Одноместный номер")
            {
                pictureBox1.Load("../../Pictures/1seat.jpeg");
            }

            if (RoomName == "Двухместный номер")
            {
                pictureBox1.Load("../../Pictures/2seat.jpeg");
            }
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }
    }
}
