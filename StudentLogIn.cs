using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fp1
{
    public partial class StudentLogIn : Form
    {
        public StudentLogIn()
        {
            InitializeComponent();
        }

        private void btnStudLogIn_Click(object sender, EventArgs e)
        {
            Form MainDashboard = new MainDashboard();
            MainDashboard.Show();
            this.Hide();
        }
    }
}
