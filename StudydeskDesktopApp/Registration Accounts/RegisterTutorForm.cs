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
    public partial class RegisterTutors : Form
    {
        private OpenFileDialog openImage = new OpenFileDialog();
        private StudydeskDesktopApp.PostTutor.WebServicePostTutor postTutor;
        StudydeskDesktopApp.GetCareers.WebServiceGetCareers getCareers;
        StudydeskDesktopApp.GetUniversities.WebServiceGetUniversities getUniversities;
        StudydeskDesktopApp.GetCourses.WebServiceGetCourses getCourses;
        DataSet tableCareer;
        DataSet tableCourses;

        public RegisterTutors()
        {
            InitializeComponent();
            InitializeWebServices();
        }

        public void InitializeWebServices() {
            postTutor = new StudydeskDesktopApp.PostTutor.WebServicePostTutor();
            getCareers = new StudydeskDesktopApp.GetCareers.WebServiceGetCareers();
            getUniversities = new StudydeskDesktopApp.GetUniversities.WebServiceGetUniversities();
            getCourses = new StudydeskDesktopApp.GetCourses.WebServiceGetCourses();

            postTutor.AuthHeaderValue = new StudydeskDesktopApp.PostTutor.AuthHeader
            {
                Username = "studydesk",
                Password = "x6$XEx$Ln@8oSsDreXo74BfYHj8SAoXkxP779qjQ"
            };
            getCareers.AuthHeaderValue = new StudydeskDesktopApp.GetCareers.AuthHeader
            {
                Username = "studydesk",
                Password = "x6$XEx$Ln@8oSsDreXo74BfYHj8SAoXkxP779qjQ"
            };
            getUniversities.AuthHeaderValue = new StudydeskDesktopApp.GetUniversities.AuthHeader
            {
                Username = "studydesk",
                Password = "x6$XEx$Ln@8oSsDreXo74BfYHj8SAoXkxP779qjQ"
            };
            getCourses.AuthHeaderValue = new StudydeskDesktopApp.GetCourses.AuthHeader
            {
                Username = "studydesk",
                Password = "x6$XEx$Ln@8oSsDreXo74BfYHj8SAoXkxP779qjQ"
            };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void label_login_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox_name.Text == "" || textBox_latsname.Text == "" || rtbDescription.Text == "" || textBox_email.Text == "" || textBox_contraseña.Text == "")
            {
                MessageBox.Show("Completa todos los campos", "Importante", MessageBoxButtons.OK);
            }
            else
            {
                

                if (openImage.FileName != string.Empty)
                {
                    CloudinaryApi cloudinaryApi = new CloudinaryApi();
                    string uploadedUrl = cloudinaryApi.uploadImage(openImage);


                    string response = postTutor.InsertarTutor(textBox_name.Text,
                        textBox_latsname.Text,
                        rtbDescription.Text,
                        uploadedUrl,
                        textBox_email.Text,
                        textBox_contraseña.Text,
                        Convert.ToDouble(textBox_pricePhour.Text),
                        Int32.Parse(cbCourse.SelectedValue.ToString())).Message;

                    nextPageConfirmation(response);
                }
                else {

                    string response = postTutor.InsertarTutor(textBox_name.Text,
                        textBox_latsname.Text,
                        rtbDescription.Text,
                        "https://res.cloudinary.com/dwhagi5eg/image/upload/v1636674995/gjipugw9leeg9tae72e4.png",
                        textBox_email.Text,
                        textBox_contraseña.Text,
                         Convert.ToDouble(textBox_pricePhour.Text),
                        Int32.Parse(cbCourse.SelectedValue.ToString())).Message;

                    nextPageConfirmation(response);
                }
            }
        }

        private void nextPageConfirmation(string response) {
            DialogResult result;

            if (response == "An Tutor was inserted without problems")
            {
                result = MessageBox.Show("Registro satisfactorio, ahora inicie sesión", "Mensaje");
                if (result == DialogResult.OK)
                {
                    /*SdApp form1 = new SdApp();
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();*/
                    this.Hide();
                    LoginForm.Instance.Show();
                    this.Close();
                }
            }
            else {
                MessageBox.Show(response, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }



        private void RegisterTutors_Load(object sender, EventArgs e)
        {
            DataSet tableUni = getUniversities.ListaUniversidades();
            cbUniversity.DataSource = tableUni.Tables[0];
            cbUniversity.ValueMember = "id";
            cbUniversity.DisplayMember = "name";

            tableCareer = getCareers.ListaCarreras();
            tableCourses = getCourses.ListaCursos();
        }

        private void RegisterTutors_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            LoginForm.Instance.Show();
        }

        private void cbUniversity_SelectedValueChanged(object sender, EventArgs e)
        {
            if (tableCareer != null)
            {
                string filter = string.Format("university_id = {0}", cbUniversity.SelectedValue.ToString());

                cbCareer.DataSource = tableCareer.Tables[0].Select(filter).CopyToDataTable();
                cbCareer.ValueMember = "id";
                cbCareer.DisplayMember = "name";

                
            }
        }

        private void cbCourse_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbCareer_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(cbCareer.SelectedValue.ToString(),out _)) {

                if (tableCourses != null)
                {
                    string filter2 = string.Format("career_id = {0}", cbCareer.SelectedValue.ToString());

                    cbCourse.DataSource = tableCourses.Tables[0].Select(filter2).CopyToDataTable();
                    cbCourse.ValueMember = "id";
                    cbCourse.DisplayMember = "name";
                }
            }
        }
    }
}
