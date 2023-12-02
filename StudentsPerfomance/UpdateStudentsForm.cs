using Microsoft.Data.SqlClient;
using StudentsPerformanceLogic;
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
    public partial class UpdateStudentsForm : Form
    {
        private DataGridViewRow row;

        public UpdateStudentsForm(DataGridViewRow row)
        {
            InitializeComponent();

            this.row = row;
            AddCmbBoxData("SELECT * FROM Classes ORDER BY className", updateClassCmbBox);
            LoadDataToFields();
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
                comboBox.DisplayMember = "className";
                comboBox.ValueMember = "id";
            }
        }

        private void LoadDataToFields()
        {
            updateStudentFirstNameTextBox.Text = (string)row.Cells[2].Value;
            updateStudentMiddleNameTextBox.Text = (string)row.Cells[3].Value;
            updateStudentLastNameTextBox.Text = (string)row.Cells[1].Value;
            updateDateOfBirthTimePicker.Value = (DateTime)row.Cells[4].Value;
            updateAdressTextBox.Text = (string)row.Cells[5].Value;
            updateClassCmbBox.Text = (string)row.Cells[6].Value;
        }

        private void saveUpdatesBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spStudents_UpdateStudent", sqlConnection);

                sqlCommand.Parameters.Add(new SqlParameter("@firstName", updateStudentFirstNameTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@middleName", updateStudentMiddleNameTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@lastName", updateStudentLastNameTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@adress", updateAdressTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@dateOfBirth", updateDateOfBirthTimePicker.Value.Date));
                sqlCommand.Parameters.Add(new SqlParameter("@classId", (int)updateClassCmbBox.SelectedValue));
                sqlCommand.Parameters.Add(new SqlParameter("@studentId", (int)row.Cells[0].Value));

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.ExecuteNonQuery();
            }

            this.Close();
        }
    }
}
