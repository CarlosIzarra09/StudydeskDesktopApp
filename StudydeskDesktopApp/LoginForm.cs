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
    public partial class LoginForm : Form
    {
        public static LoginForm Instance = null;
        public LoginForm()
        {
            InitializeComponent();
            Instance = this;
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            StudydeskDesktopApp.Authentication.WebServiceAuthentication authenticateUser = new StudydeskDesktopApp.Authentication.WebServiceAuthentication();
            StudydeskDesktopApp.Authentication.AuthenticationResponse response;
            if (checkBIsTutor.Checked)
                response = authenticateUser.AutenticarUsuarioTutor(txbEmail.Text, txbPassword.Text);
            else
                response = authenticateUser.AutenticarUsuarioEstudiante(txbEmail.Text, txbPassword.Text);
            
            DialogResult result;
            if (response.Success == false)
            {
                MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                result = MessageBox.Show(response.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    
                    SdApp form1 = new SdApp(
                        response.Resource.Id,
                        checkBIsTutor.Checked
                        );
                    this.Hide();
                    form1.Show();
                    this.txbPassword.Text = string.Empty;
                    //this.Close();
                    //Application.Exit();
                }

            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OptionRegister form1 = new OptionRegister();
            form1.Show();
        }
    }
}
