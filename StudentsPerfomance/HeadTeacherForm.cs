using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsPerfomance
{
    public partial class HeadTeacherForm : Form
    {
        public HeadTeacherForm()
        {
            InitializeComponent();
        }

        private void workWithStudentsBtn_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            this.Hide();
            studentsForm.ShowDialog();
        }

        private void HeadTeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.ShowDialog();
        }
    }
}
