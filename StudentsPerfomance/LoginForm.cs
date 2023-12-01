using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using StudentsPerfomanceLogic;

namespace StudentsPerfomance
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var user = GlobalConfig.Connection.GetUserByLoginAndPassword(loginTextBox.Text.Trim(), passwordTextBox.Text.Trim());

            if (user != null)
            {
                switch (user.RoleId)
                {
                    case 2:
                        HeadTeacherForm headTeacherForm = new HeadTeacherForm();
                        this.Hide();
                        headTeacherForm.ShowDialog();
                        break;
                    case 3:
                        TeachersForm teachers = new TeachersForm(user.userId, false);
                        this.Hide();
                        teachers.ShowDialog();
                        break;
                    case 4:
                        StudentInfoForm studentInfoForm = new StudentInfoForm(user.userId);
                        this.Hide();
                        studentInfoForm.ShowDialog();
                        break;
                    case 5:
                        StaffForm staffForm = new StaffForm();
                        this.Hide();
                        staffForm.ShowDialog();
                        break;
                    case 6:
                        TeachersForm classTeachers = new TeachersForm(user.userId, true);
                        this.Hide();
                        classTeachers.ShowDialog();
                        break;
                } 
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            Environment.Exit(0);
        }
    }
}
