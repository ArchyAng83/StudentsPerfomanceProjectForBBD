using Microsoft.Data.SqlClient;
using StudentsPerformance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsPerformance
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();

            AddCmbBoxData("SELECT * FROM Roles WHERE Roles.Id = 3 OR Roles.Id = 6", roleTeacherCmbBox);
            AddCmbBoxData("SELECT * FROM Subjects", subjectCmbBox);                       
        }

        private void saveTeacherBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                InsertTeacher();
            }
            else
            {
                MessageBox.Show("Неверный ввод данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                        
            this.Close();
        }

        private void AddCmbBoxData(string sqlExpresion, ComboBox comboBox)
        {
            using (SqlConnection sqlConnection = new SqlConnection(GlobalConfig.connectionString))
            {
                sqlConnection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlExpresion, sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                comboBox.DataSource = dataTable;
                comboBox.DisplayMember = "name";
                comboBox.ValueMember = "id";
            }
        }

        private void InsertTeacher()
        {
            using (SqlConnection sqlConnection = new SqlConnection(GlobalConfig.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spTeacher_InsertTeacher", sqlConnection);
               
                sqlCommand.Parameters.Add(new SqlParameter("@firstName", firstNameTeacherTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@middleName", middleNameTeacherTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@lastName", lastNameTeacherTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@phone", phoneTeacherTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@roleId", (int)roleTeacherCmbBox.SelectedValue));
                sqlCommand.Parameters.Add(new SqlParameter("@subjectId", (int)subjectCmbBox.SelectedValue));
                sqlCommand.Parameters.Add(new SqlParameter("@password", GeneratePass()));

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.ExecuteNonQuery();
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (firstNameTeacherTextBox.Text.Length < 2)
            {
                output = false;
            }

            if (middleNameTeacherTextBox.Text.Length < 2)
            {
                output = false;
            }

            if (lastNameTeacherTextBox.Text.Length < 2)
            {
                output = false;
            }

            return output;
        }

        private string GeneratePass()
        {
            string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            Random rnd = new Random();
            StringBuilder builder = new StringBuilder(7);
            for (int i = 0; i < 7; i++)
            {
                builder.Append(arr[rnd.Next(0, 10)]);
            }

            return builder.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddSubjectForm addSubjectForm = new AddSubjectForm();
            addSubjectForm.ShowDialog();
            AddCmbBoxData("SELECT * FROM Subjects", subjectCmbBox);
        }
    }
}
