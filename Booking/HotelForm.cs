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
        public Label lbl;

        public Hotel(string _Name, string _City, int _Rating, string _Adress)
        {
            Name = _Name;
            City = _City;
            Rating = _Rating;
            Picture_Andess = _Adress;
            pb = new PictureBox();
            pb.Load("../../Pictures/" + _Adress);
            lbl = new Label();
        }
    }

    public partial class HotelForm : Form
    {
        public static string HotelName;
        public static int Rating;

        public HotelForm(Hotel hotel)
        {
            InitializeComponent();

            HotelName = hotel.Name;
            Rating = hotel.Rating;

            pictureBox1.Image = hotel.pb.Image;
            
            Text = hotel.Name;
            label1.Text = hotel.Name;

            //Рисование звезд
            int x = 396;
            for(int i=0; i<hotel.Rating; i++)
            {
                PictureBox box = new PictureBox();
                box.Load("../../Pictures/star.png");
                box.Location = new Point(x, 53);
                box.Size = new Size(30, 30);
                box.SizeMode = PictureBoxSizeMode.Zoom;                
                InfoPanel.Controls.Add(box);

                x += 35;
            }

        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm rf = new RoomForm(HotelName, pb.Tag.ToString(), Rating);
            rf.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Label pb = (Label)sender;
            RoomForm rf = new RoomForm(HotelName, pb.Text, Rating);
            rf.Show();
        }
    }
}
