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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            StudydeskDesktopApp.Authenticate.WebServiceAuthentication authenticateUser = new StudydeskDesktopApp.Authenticate.WebServiceAuthentication();
            StudydeskDesktopApp.Authenticate.ResponseService response;
            if (checkBIsTutor.Checked)
                response = authenticateUser.AutenticarUsuarioTutor(txbEmail.Text, txbPassword.Text);
            else
                response = authenticateUser.AutenticarUsuarioEstudiante(txbEmail.Text, txbPassword.Text);
            
            DialogResult result;
            if (response.Status == "error")
            {
                result = MessageBox.Show(response.Message, response.Status, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                result = MessageBox.Show(response.Message, response.Status, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    
                    SdApp form1 = new SdApp();
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();
                    //Application.Exit();
                }

            }

            
        }
    }
}
