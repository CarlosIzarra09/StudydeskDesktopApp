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

        public RegisterStudent()
        {
            InitializeComponent();
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
            
            if (textBox_name.Text == "" || textBox_latsname.Text == "" || textBox_email.Text == "" || textBox_contraseña.Text == "")
            {
                MessageBox.Show("Completa todos los campos","Importante",MessageBoxButtons.OK);
            }
            else {
                
                StudydeskDesktopApp.PostStudent.WebServicePostStudent postStudent = new StudydeskDesktopApp.PostStudent.WebServicePostStudent();


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
                        1);//id de carrera, esto se escoge, pero por ahora es 1 por defecto
                    
                    nextPageConfirmation(response);
                }
                else {
                    string response = postStudent.InsertarEstudiante(textBox_name.Text, 
                        textBox_latsname.Text, 
                        "No image", 
                        textBox_email.Text, 
                        textBox_contraseña.Text, 
                        0, 
                        1);

                    nextPageConfirmation(response);
                }

             
            }
        }

        private void nextPageConfirmation(string response)
        {
            DialogResult result;

            if (response == "A Student was inserted without problems")
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
            }
        }
    }
}
