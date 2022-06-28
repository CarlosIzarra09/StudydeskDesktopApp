using StudydeskDesktopApp.Menu;
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
        //public static SdApp Instance = null;
        public int userId = 0;
        public bool userIsTutor = false;
        public SdApp(int id,bool isTutor)
        {
            InitializeComponent();
            //Instance = this;
            this.userId = id;
            this.userIsTutor = isTutor;
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
            if (DashboardForm.Instance != null)
                loadForm(DashboardForm.Instance);
            else { 
                loadForm(new DashboardForm());
            }
        }

        private void button_TutorsForm_Click(object sender, EventArgs e)
        {
            if (TutorsForm.Instance != null) {
                loadForm(TutorsForm.Instance);
            }
            else { 
                loadForm(new TutorsForm());
            }
        }

        private void button_CoursesForm_Click(object sender, EventArgs e)
        {
            loadForm(new CoursesForm());
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            if (ProfileForm.Instance != null )
            {
                loadForm(ProfileForm.Instance);
            }
            else {
                
                loadForm(new ProfileForm(this.userId,this.userIsTutor));
            }
        }




        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            /*Login form1 = new Login();
            this.Hide();
            form1.ShowDialog();
            this.Close();*/
            this.Hide();
            LoginForm.Instance.Show();
            this.Close();
            //this.Close();
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SdApp_Load(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(0, 0, MainPanel.Width, MainPanel.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 50;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            MainPanel.Region = new Region(gp);
        }

        private void SdApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Elimino todas las instancias singleton para evitar ObjectDisposedException
            DashboardForm.Instance = null;
            ProfileForm.Instance = null;
            TutorsForm.Instance = null;
        }
    }
}
