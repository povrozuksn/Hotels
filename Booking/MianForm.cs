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
    public partial class MainForm : System.Windows.Forms.Form
    {

        public static List<Hotel> hotels = new List<Hotel>();

        public MainForm()
        {
            InitializeComponent();

            string[] lines = System.IO.File.ReadAllLines("Гостиницы.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] {", "}, StringSplitOptions.None);
                Hotel hotel = new Hotel(parts[0], parts[1], Convert.ToInt32(parts[2]), parts[3]); 
                hotels.Add(hotel); 
            }

            int x = 17;
            foreach (Hotel hotel in hotels)
            {
                hotel.pb.Location = new Point(x, 20);
                hotel.pb.Size = new Size(180, 90);
                hotel.pb.Image = hotel.pb.Image;
                hotel.pb.SizeMode=PictureBoxSizeMode.Zoom;
                hotel.pb.Tag = hotel.Name;
                hotel.pb.Click += new EventHandler(pictureBox3_Click);
                HotelsPanel.Controls.Add(hotel.pb);

                hotel.lbl.Location = new Point(x, 120);
                hotel.lbl.Size = new Size(200, 20);
                hotel.lbl.Font = new Font("Microsoft Sans Serif", 12);
                hotel.lbl.Text = hotel.Name;
                hotel.lbl.Click += new EventHandler(label6_Click);
                HotelsPanel.Controls.Add(hotel.lbl);

                x += 200;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FiltrButton_Click(object sender, EventArgs e)
        {
            if (FiltrPanel.Size.Height < 50)
            {
                FiltrPanel.Size = new Size(FiltrPanel.Width, 120);
            }
            else
            {
                FiltrPanel.Size = new Size(FiltrPanel.Width, FiltrButton.Size.Height);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           PictureBox pb = (PictureBox)sender;

            foreach(Hotel hotel in hotels)
            {
                if(hotel.pb.Image == pb.Image)
                {
                    HotelForm hf = new HotelForm(hotel);
                    hf.Show();
                }
            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Label pb = (Label)sender;
            foreach (Hotel hotel in hotels)
            {
                if (hotel.Name == pb.Text)
                {
                    HotelForm hf = new HotelForm(hotel);
                    hf.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (Hotel hotel in hotels)
            {
                bool Visible = true;
                if (CytiComboBox.Text != "" && CytiComboBox.Text != hotel.City)
                {
                    Visible = false;
                }
               
                hotel.pb.Visible = Visible;
                hotel.lbl.Visible = Visible;

            }
        }
    }
}
