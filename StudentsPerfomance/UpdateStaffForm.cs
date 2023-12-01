using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsPerfomanceLogic;

namespace StudentsPerfomance
{
    public partial class UpdateStaffForm : Form
    {
        private DataGridViewRow row;

        public UpdateStaffForm(DataGridViewRow row)
        {
            InitializeComponent();
            this.row = row;
            AddCmbBoxData("SELECT * FROM Roles WHERE Roles.Id = 3 OR Roles.Id = 6", roleTeacherCmbBox);
            AddCmbBoxData("SELECT * FROM Subjects", subjectCmbBox);
            LoadDataToFields();
        }

        private void LoadDataToFields()
        {
            firstNameTeacherTextBox.Text = (string)row.Cells[2].Value;
            middleNameTeacherTextBox.Text = (string)row.Cells[3].Value;
            lastNameTeacherTextBox.Text = (string)row.Cells[1].Value;
            phoneTeacherTextBox.Text = (string)row.Cells[5].Value;
        }

        private void AddCmbBoxData(string sqlExpresion, ComboBox comboBox)
        {
            using (SqlConnection sqlConnection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
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

        private void saveTeacherBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spTeacher_UpdateTeacher", sqlConnection);

                sqlCommand.Parameters.Add(new SqlParameter("@firstName", firstNameTeacherTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@middleName", middleNameTeacherTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@lastName", lastNameTeacherTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@phone", phoneTeacherTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@roleId", (int)roleTeacherCmbBox.SelectedValue));
                sqlCommand.Parameters.Add(new SqlParameter("@subjectId", (int)subjectCmbBox.SelectedValue));
                sqlCommand.Parameters.Add(new SqlParameter("@teacherId", (int)row.Cells[0].Value));

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.ExecuteNonQuery();
            }

            this.Close();
        }
    }
}
