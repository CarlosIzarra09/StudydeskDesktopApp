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
    public partial class SdApp : Form
    {
        public SdApp()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void button_Dashboard_Click(object sender, EventArgs e)
        {
            loadForm(new DashBoardForm());
        }

        private void button_TutorsForm_Click(object sender, EventArgs e)
        {
            loadForm(new TutorsForm());
        }

        private void button_CoursesForm_Click(object sender, EventArgs e)
        {
            loadForm(new CoursesForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
