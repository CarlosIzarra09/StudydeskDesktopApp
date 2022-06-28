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
    public partial class RegisterStudent : Form
    {
        OpenFileDialog openImage = new OpenFileDialog();
        StudydeskDesktopApp.PostStudent.WebServicePostStudent postStudent;

        public RegisterStudent()
        {
            InitializeComponent();
            InitializeWebServices();
        }

        public void InitializeWebServices() {
            postStudent = new StudydeskDesktopApp.PostStudent.WebServicePostStudent();
            postStudent.AuthHeaderValue = new StudydeskDesktopApp.PostStudent.AuthHeader
            {
                Username = "studydesk",
                Password = "x6$XEx$Ln@8oSsDreXo74BfYHj8SAoXkxP779qjQ"
            };
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
            
            if (textBox_name.Text == "" || textBox_latsname.Text == "" || textBox_email.Text == "" || textBox_contraseña.Text == "")
            {
                MessageBox.Show("Completa todos los campos","Importante",MessageBoxButtons.OK);
            }
            else {
                
      
                if (openImage.FileName != string.Empty)
                {

                    CloudinaryApi cloudinaryApi = new CloudinaryApi();
                    string uploadedUrl = cloudinaryApi.uploadImage(openImage);

                    string response = postStudent.InsertarEstudiante(textBox_name.Text, 
                        textBox_latsname.Text, 
                        uploadedUrl, 
                        textBox_email.Text, 
                        textBox_contraseña.Text, 
                        0, //IMPORTANT: ISTUTOR ALWAYS WILL BE "0", but if someone have sufficient time for coding "student BECOMES tutor" option.... 
                        1).Message;//id de carrera, esto se escoge, pero por ahora es 1 por defecto
                    
                    nextPageConfirmation(response);
                }
                else {
                    string response = postStudent.InsertarEstudiante(textBox_name.Text, 
                        textBox_latsname.Text,
                        "https://res.cloudinary.com/dwhagi5eg/image/upload/v1636674995/gjipugw9leeg9tae72e4.png", 
                        textBox_email.Text, 
                        textBox_contraseña.Text, 
                        0, 
                        1).Message;

                    nextPageConfirmation(response);
                }

             
            }
        }

        private void nextPageConfirmation(string response)
        {
            DialogResult result;

            if (response == "A Student was inserted without problems")
            {
                result = MessageBox.Show("Registro satisfactorio, ahora inicie sesión", "Mensaje");
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    LoginForm.Instance.Show();
                    this.Close();
                    /*SdApp form1 = new SdApp();
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();*/
                }
            }
            else
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
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

        private void RegisterStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            LoginForm.Instance.Show();
        }
    }
}
