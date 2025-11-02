using System;
using System.Windows.Forms;

namespace Image_gallery
{
    public partial class Image_gallery : Form
    {
        int currentIndex = 0;
        private readonly object[] images =
        {
            Properties.Resources._11_1,
            Properties.Resources._11_2,
            Properties.Resources._11_3,
            Properties.Resources._11_4

        };
        private void ShowImage()
        {
            pictureBox1.Image = (System.Drawing.Image)images[currentIndex];
        }
        public Image_gallery()
        {
            InitializeComponent();
            ShowImage();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= images.Length) currentIndex = 0;
            ShowImage();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0) currentIndex = images.Length - 1;
            ShowImage();

        }
    }
}
