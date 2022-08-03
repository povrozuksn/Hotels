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
    public struct Hotel
    {
        public string Name;
        public string City;
        public int Rating;
        public string Picture_Andess;
        public PictureBox pb;

        public Hotel(string _Name, string _City, int _Rating, string _Adress)
        {
            Name = _Name;
            City = _City;
            Rating = _Rating;
            Picture_Andess = _Adress;
            pb = new PictureBox();
            pb.Load("../../Pictures/" + _Adress);
        }
    }

    public partial class HotelForm : Form
    {
        string HotelName;

        public HotelForm(string _HotelName)
        {
            InitializeComponent();

            HotelName = _HotelName;

            if (HotelName == "Гостиница \"Москва\"")
            {
                pictureBox1.Load("../../Pictures/Moskva.jpeg");
            }

            if (HotelName == "Гостиница \"Националь\"")
            {
                pictureBox1.Load("../../Pictures/Nacional.jpeg");
            }

            if (HotelName == "Гостиница \"Апарт\"")
            {
                pictureBox1.Load("../../Pictures/Apart.jpeg");
            }

            Text = HotelName;
            label1.Text = HotelName;
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm rf = new RoomForm(HotelName, pb.Tag.ToString());
            rf.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Label pb = (Label)sender;
            RoomForm rf = new RoomForm(HotelName, pb.Text);
            rf.Show();
        }
    }
}
