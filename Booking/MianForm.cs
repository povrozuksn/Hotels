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

        List<Hotel> hotels = new List<Hotel>();

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
                PictureBox box = new PictureBox();
                box.Location = new Point(x, 20);
                box.Size = new Size(180, 90);
                box.Image = hotel.pb.Image;
                box.SizeMode=PictureBoxSizeMode.Zoom;
                box.Tag = hotel.Name;
                box.Click += new EventHandler(pictureBox3_Click);
                HotelsPanel.Controls.Add(box);

                Label label = new Label();
                label.Location = new Point(x, 120);
                label.Size = new Size(200, 20);
                label.Font = new Font("Microsoft Sans Serif", 12);
                label.Text = hotel.Name;
                label.Click += new EventHandler(label6_Click);
                HotelsPanel.Controls.Add(label);

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
           HotelForm hf = new HotelForm(pb.Tag.ToString());
           hf.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Label pb = (Label)sender;
            HotelForm hf = new HotelForm(pb.Text);
            hf.Show();
        }
    }
}
