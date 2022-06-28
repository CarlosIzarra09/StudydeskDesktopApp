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
        private OpenFileDialog openImage = new OpenFileDialog();
        private StudydeskDesktopApp.GetTutorById.WebServiceGetTutorById tutorById;
        private StudydeskDesktopApp.GetStudentById.WebServiceGetStudentById studentById;


        public static ProfileForm Instance = null;
        public int userId = 0;
        public bool userIsTutor = false;
        public ProfileForm(int id,bool isTutor)
        {
            InitializeComponent();
            InitializeWebServices();
            Instance = this;
            this.userId = id;
            this.userIsTutor = isTutor;
            
        }

        public void InitializeWebServices() {

            this.tutorById = new StudydeskDesktopApp.GetTutorById.WebServiceGetTutorById();
            
            tutorById.AuthHeaderValue = new StudydeskDesktopApp.GetTutorById.AuthHeader
            {
                Username = "studydesk",
                Password = "x6$XEx$Ln@8oSsDreXo74BfYHj8SAoXkxP779qjQ"
            };

            this.studentById = new StudydeskDesktopApp.GetStudentById.WebServiceGetStudentById();
            studentById.AuthHeaderValue = new StudydeskDesktopApp.GetStudentById.AuthHeader
            {
                Username = "studydesk",
                Password = "x6$XEx$Ln@8oSsDreXo74BfYHj8SAoXkxP779qjQ"
            };
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
                
                StudydeskDesktopApp.GetTutorById.TutorResponse response;

                response = tutorById.RetornarUsuarioTutorPorId(this.userId);

                txt_mail.Text = response.Resource.Email;
                txtName.Text = response.Resource.Name;
                txtLastname.Text = response.Resource.LastName;
                txtDescription.Text = response.Resource.Description;
                logo.LoadAsync(response.Resource.Logo);
            }
            else {
                ////////////////////student case
                
                StudydeskDesktopApp.GetStudentById.StudentResponse response;


                response = studentById.RetornarUsuarioEstudiantePorId(this.userId);

                txtName.Text = response.Resource.Name;
                txtLastname.Text = response.Resource.LastName;
                txtDescription.Text = "Soy un estudiante";
                logo.LoadAsync(response.Resource.Logo);
            }





        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            EditProfile form1 = new EditProfile(this.userId, this.userIsTutor);
            form1.Show();
        }
    }
}
