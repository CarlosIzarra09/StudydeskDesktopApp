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
            DialogResult result;
            if (textBox_name.Text == "" || textBox_latsname.Text == "" || textBox_email.Text == "" || textBox_contraseña.Text == "")
            {
                result = MessageBox.Show("Completa todos los campos");
            }
            else {
                StudydeskDesktopApp.PostStudent.WebServicePostStudent post = new StudydeskDesktopApp.PostStudent.WebServicePostStudent();
                post.InsertarEstudiante(textBox_name.Text, textBox_latsname.Text, textBox_email.Text, "logo.png", textBox_contraseña.Text, 0, 1);
                result = MessageBox.Show("Registro Satisfactorio");
                if (result == DialogResult.OK) {
                    
                    Login form1 = new Login();
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();
                }

            }
        }
    }
}
