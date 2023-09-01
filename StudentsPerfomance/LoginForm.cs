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

namespace StudentsPerfomance
{
    public partial class LoginForm : Form
    {
        private int roleId;
        private int userId;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            ValidateEnter(login, password);
            switch (roleId)
            {
                case 2:
                    HeadTeacherForm headTeacherForm = new HeadTeacherForm();
                    this.Hide();
                    headTeacherForm.ShowDialog();
                    break;
                case 3:
                    TeachersForm teachers = new TeachersForm(userId, false);
                    this.Hide();
                    teachers.ShowDialog();
                    break;
                case 4:
                    StudentInfoForm studentInfoForm = new StudentInfoForm(userId);
                    this.Hide();
                    studentInfoForm.ShowDialog();
                    break;
                case 5:
                    StaffForm staffForm = new StaffForm();
                    this.Hide();
                    staffForm.ShowDialog();
                    break;
                case 6:
                    TeachersForm classTeachers = new TeachersForm(userId, true);
                    this.Hide();
                    classTeachers.ShowDialog();
                    break;
                default:
                    MessageBox.Show($"Неверный логин или пароль");
                    break;
            }
        }

        //WHERE Users.login = N'З1' and Users.password = '111111'

        private void ValidateEnter(string login, string password)
        {
            string sqlExpresion = "spUsers_GetLoginAndPassword";
            using (SqlConnection connection = new SqlConnection(GlobalConfig.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpresion, connection);

                SqlParameter loginParam = new SqlParameter("@login", login);
                SqlParameter passwordParam = new SqlParameter("@password", password);
                command.Parameters.Add(loginParam);
                command.Parameters.Add(passwordParam);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        roleId = reader.GetInt32(3);
                        userId = reader.GetInt32(0);
                    }
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            Environment.Exit(0);
        }
    }
}
