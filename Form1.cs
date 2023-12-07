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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Form TeacherLogIn = new TeacherLogIn();
            TeacherLogIn.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Form StudentLogIn = new StudentLogIn();
            StudentLogIn.Show();
            this.Hide();


        }
    }
}
