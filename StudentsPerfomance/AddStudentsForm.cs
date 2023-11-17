using Microsoft.Data.SqlClient;
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
    public partial class AddStudentsForm : Form
    {
        public AddStudentsForm()
        {
            InitializeComponent();

            AddCmbBoxData("SELECT * FROM Classes ORDER BY className", classStudentCmbBox);
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
                comboBox.DisplayMember = "className";
                comboBox.ValueMember = "id";
            }
        }

        private void saveStudentBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                InsertStudent();
            }
            else
            {
                MessageBox.Show("Неверный ввод данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                        
            this.Hide();
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (firstNameStudentTextBox.Text.Length < 2)
            {
                output = false;
            }

            if (middleNameStudentTextBox.Text.Length < 2)
            {
                output = false;
            }

            if (lastNameStudentTextBox.Text.Length < 2)
            {
                output = false;
            }

            if (adressTextBox.Text.Length < 2)
            {
                output = false;
            }

            return output;
        }

        private void InsertStudent()
        {
            using (SqlConnection sqlConnection = new SqlConnection(GlobalConfig.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spStudents_InsertStudent", sqlConnection);

                sqlCommand.Parameters.Add(new SqlParameter("@firstName", firstNameStudentTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@middleName", middleNameStudentTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@lastName", lastNameStudentTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@dateOfBirth", dateOfBirthTimePicker.Value.Date));
                sqlCommand.Parameters.Add(new SqlParameter("@adress", adressTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@classId", (int)classStudentCmbBox.SelectedValue));
                sqlCommand.Parameters.Add(new SqlParameter("@password", GeneratePass()));


                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.ExecuteNonQuery();
            }
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
    }
}
