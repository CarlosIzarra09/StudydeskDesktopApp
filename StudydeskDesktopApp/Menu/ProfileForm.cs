using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudydeskDesktopApp.Menu
{
    public partial class ProfileForm : Form
    {
        OpenFileDialog openImage = new OpenFileDialog();


        public static ProfileForm Instance = null;
        public int userId = 0;
        public bool userIsTutor = false;
        public ProfileForm(int id,bool isTutor)
        {
            InitializeComponent();
            Instance = this;
            this.userId = id;
            this.userIsTutor = isTutor;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            
            Rectangle r = new Rectangle(0, 0, logo.Width, logo.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 50;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            logo.Region = new Region(gp);

            if (this.userIsTutor)
            {
                StudydeskDesktopApp.GetTutorById.WebServiceGetTutorById tutorById = new StudydeskDesktopApp.GetTutorById.WebServiceGetTutorById();
                StudydeskDesktopApp.GetTutorById.TutorResponse response;

                response = tutorById.RetornarUsuarioTutorPorId(this.userId);

                txtName.Text = response.Resource.Name;
                txtLastname.Text = response.Resource.LastName;
                txtDescription.Text = response.Resource.Description;
                logo.LoadAsync(response.Resource.Logo);
            }
            else {
                ////////////////////student case
                StudydeskDesktopApp.GetStudentById.WebServiceGetStudentById studentById = new StudydeskDesktopApp.GetStudentById.WebServiceGetStudentById();
                StudydeskDesktopApp.GetStudentById.StudentResponse response;

                response = studentById.RetornarUsuarioEstudiantePorId(this.userId);

                txtName.Text = response.Resource.Name;
                txtLastname.Text = response.Resource.LastName;
                txtDescription.Text = "Soy un estudiante";
                logo.LoadAsync(response.Resource.Logo);
            }

            


        }

        private void logo_Click(object sender, EventArgs e)
        {
           // StudydeskDesktopApp.Put.WebServicePostTutor postTutor = new StudydeskDesktopApp.PostTutor.WebServicePostTutor();
        }
    }
}
