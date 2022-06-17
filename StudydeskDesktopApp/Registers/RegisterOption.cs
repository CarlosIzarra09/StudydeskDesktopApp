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
    public partial class OptionRegister : Form
    {
        public OptionRegister()
        {
            InitializeComponent();
        }

        private void OptionRegister_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Tutor_Click(object sender, EventArgs e)
        {
            RegisterTutors form1 = new RegisterTutors();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button_student_Click(object sender, EventArgs e)
        {
            RegisterStudent form1 = new RegisterStudent();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        
    }
}
