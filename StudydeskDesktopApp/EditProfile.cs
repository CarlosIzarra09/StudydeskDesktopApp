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
    public partial class EditProfile : Form
    {
        private OpenFileDialog openImage = new OpenFileDialog();
        private StudydeskDesktopApp.GetTutorById.WebServiceGetTutorById tutorById;
        private StudydeskDesktopApp.GetStudentById.WebServiceGetStudentById studentById;
        private StudydeskDesktopApp.PutTutor.WebServiceUpdateTutor updateTutorById;
        public static EditProfile Instance = null;
        public int userId = 0;
        public bool userIsTutor = false;
        public EditProfile(int id, bool isTutor)
        {
            InitializeComponent();
            InitializeWebServices();
            Instance = this;
            this.userId = id;
            this.userIsTutor = isTutor;
        }

        public void InitializeWebServices()
        {

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

        private void EditProfile_Load(object sender, EventArgs e)
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

                textBox_mail.Text = response.Resource.Email;
                textBox_name.Text = response.Resource.Name;
                textBox_lastname.Text = response.Resource.LastName;
                richTextBox_descripcion.Text = response.Resource.Description;
                logo.LoadAsync(response.Resource.Logo);
            }
            else
            {
                ////////////////////student case

                StudydeskDesktopApp.GetStudentById.StudentResponse response;


                response = studentById.RetornarUsuarioEstudiantePorId(this.userId);

                textBox_mail.Text = response.Resource.Email;
                textBox_name.Text = response.Resource.Name;
                textBox_lastname.Text = response.Resource.LastName;
                richTextBox_descripcion.Text = "Soy un estudiante";
                logo.LoadAsync(response.Resource.Logo);
            }
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

        private void btEditar_Click(object sender, EventArgs e)
        {
            StudydeskDesktopApp.GetTutorById.TutorResponse response;

            response = tutorById.RetornarUsuarioTutorPorId(this.userId);

            /*updateTutorById.ActualizarTutor(
               response.Resource.Id,
               textBox_name.Text,
               textBox_lastname.Text,
               richTextBox_descripcion.Text,
               response.Resource.Logo,
               textBox_mail.Text,
               "123",
               response.Resource.PricePerHour,
               response.Resource.CourseId
               );*/
        }
    }
}
