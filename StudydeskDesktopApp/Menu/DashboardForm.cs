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
    public partial class DashboardForm : Form
    {
        public static DashboardForm Instance = null;
        public DashboardForm()
        {
            InitializeComponent();
            Instance = this;
        }
    }
}
