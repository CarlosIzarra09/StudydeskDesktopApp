using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudydeskDesktopApp
{
    public partial class RegisterTutors : Form
    {
        public RegisterTutors()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririImagen = new OpenFileDialog();

            if (abririImagen.ShowDialog() == DialogResult.OK)
            {
                logo.ImageLocation = abririImagen.FileName;
                logo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void label_login_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudydeskDesktopApp.PostTutors.WebServicePostTutor post = new StudydeskDesktopApp.PostTutors.WebServicePostTutor();
        }
    }
}
