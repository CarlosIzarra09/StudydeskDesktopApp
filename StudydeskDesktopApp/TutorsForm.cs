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
        public TutorsForm()
        {
            InitializeComponent();
        }

        private void TutorsForm_Load(object sender, EventArgs e)
        {
            StudydeskDesktopApp.GetTutors.WebServiceGetTutors getTutors = new StudydeskDesktopApp.GetTutors.WebServiceGetTutors();
            DataSet tableTutors = getTutors.ListaTutores();
            dataGridView1.DataSource = tableTutors.Tables[0];
        }
    }
}
