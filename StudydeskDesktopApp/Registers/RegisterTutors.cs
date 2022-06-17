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
        OpenFileDialog openImage = new OpenFileDialog();

        public RegisterTutors()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                logo.ImageLocation = openImage.FileName;
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

            if (textBox_name.Text == "" || textBox_latsname.Text == "" || rtbDescription.Text == "" || textBox_email.Text == "" || textBox_contraseña.Text == "")
            {
                MessageBox.Show("Completa todos los campos", "Importante", MessageBoxButtons.OK);
            }
            else
            {
                StudydeskDesktopApp.PostTutors.WebServicePostTutor postTutor = new StudydeskDesktopApp.PostTutors.WebServicePostTutor();

                if (openImage.FileName != string.Empty)
                {
                    CloudinaryApi cloudinaryApi = new CloudinaryApi();
                    string uploadedUrl = cloudinaryApi.uploadImage(openImage);


                    string response = postTutor.InsertarTutor(textBox_name.Text,
                        textBox_latsname.Text,
                        rtbDescription.Text,
                        uploadedUrl,
                        textBox_email.Text,
                        textBox_contraseña.Text,
                        double.Parse(textBox_pricePhour.Text),
                        1);

                    nextPageConfirmation(response);
                }
                else {

                    string response = postTutor.InsertarTutor(textBox_name.Text,
                        textBox_latsname.Text,
                        "rtbDescription.Text",
                        "No image",
                        textBox_email.Text,
                        textBox_contraseña.Text,
                        double.Parse(textBox_pricePhour.Text),
                        1);

                    nextPageConfirmation(response);
                }
            }
        }

        private void nextPageConfirmation(string response) {
            DialogResult result;

            if (response == "An Tutor was inserted without problems")
            {
                result = MessageBox.Show("Registro satisfactorio", "Mensaje");
                if (result == DialogResult.OK)
                {
                    SdApp form1 = new SdApp();
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();
                }
            }
            else {
                MessageBox.Show(response, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }



        private void RegisterTutors_Load(object sender, EventArgs e)
        {

        }

        
    }
}
