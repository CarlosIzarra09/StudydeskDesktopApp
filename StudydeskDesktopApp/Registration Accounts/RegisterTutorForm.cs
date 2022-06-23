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
        private OpenFileDialog openImage = new OpenFileDialog();
        private StudydeskDesktopApp.PostTutor.WebServicePostTutor postTutor;

        public RegisterTutors()
        {
            InitializeComponent();
            InitializeWebServices();
        }

        public void InitializeWebServices() {
            postTutor = new StudydeskDesktopApp.PostTutor.WebServicePostTutor();
            postTutor.AuthHeaderValue = new StudydeskDesktopApp.PostTutor.AuthHeader
            {
                Username = "studydesk",
                Password = "x6$XEx$Ln@8oSsDreXo74BfYHj8SAoXkxP779qjQ"
            };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            

            if (openImage.ShowDialog() == DialogResult.OK)
            {
                logo.ImageLocation = openImage.FileName;
                logo.SizeMode = PictureBoxSizeMode.StretchImage;
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

                gp.AddEllipse(0, 0, logo.Width - 3, logo.Height - 3);
                Region rg = new Region(gp);
                logo.Region = rg;
            }
        }

        private void label_login_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
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
                        Convert.ToDouble(textBox_pricePhour.Text),
                        1).Message;

                    nextPageConfirmation(response);
                }
                else {

                    string response = postTutor.InsertarTutor(textBox_name.Text,
                        textBox_latsname.Text,
                        rtbDescription.Text,
                        "https://res.cloudinary.com/dwhagi5eg/image/upload/v1636674995/gjipugw9leeg9tae72e4.png",
                        textBox_email.Text,
                        textBox_contraseña.Text,
                         Convert.ToDouble(textBox_pricePhour.Text),
                        1).Message;

                    nextPageConfirmation(response);
                }
            }
        }

        private void nextPageConfirmation(string response) {
            DialogResult result;

            if (response == "An Tutor was inserted without problems")
            {
                result = MessageBox.Show("Registro satisfactorio, ahora inicie sesión", "Mensaje");
                if (result == DialogResult.OK)
                {
                    /*SdApp form1 = new SdApp();
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();*/
                    this.Hide();
                    LoginForm.Instance.Show();
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

        private void RegisterTutors_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            LoginForm.Instance.Show();
        }
    }
}
