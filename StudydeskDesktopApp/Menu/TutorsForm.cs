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
    public partial class TutorsForm : Form
    {
        public static TutorsForm Instance = null;
        private StudydeskDesktopApp.GetTutors.WebServiceGetTutors getTutors;
        public TutorsForm()
        {
            InitializeComponent();
            InitializeWebServices();
            Instance = this;
        }

        public void InitializeWebServices() {
            getTutors = new StudydeskDesktopApp.GetTutors.WebServiceGetTutors();

            getTutors.AuthHeaderValue = new StudydeskDesktopApp.GetTutors.AuthHeader
            {
                Username = "studydesk",
                Password = "x6$XEx$Ln@8oSsDreXo74BfYHj8SAoXkxP779qjQ"
            };
        }

        private void TutorsForm_Load(object sender, EventArgs e)
        {

            DataSet tableTutors = getTutors.ListaTutores();
            dataGridView1.DataSource = tableTutors.Tables[0];
        }
    }
}
