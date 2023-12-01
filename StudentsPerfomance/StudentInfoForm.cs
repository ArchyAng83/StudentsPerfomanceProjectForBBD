using Microsoft.Data.SqlClient;
using StudentsPerfomanceLogic;
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
    public partial class StudentInfoForm : Form
    {
        private int studentId;
        DataSet dataSet;
        SqlDataAdapter adapter;

        public StudentInfoForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            studentInfoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentInfoDataGridView.AllowUserToAddRows = false;
            GetFullNameAndClass();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("spStudentsMarks_GetAllMarksOfStudent", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.Add(new SqlParameter("@studentId", studentId));
                adapter = new SqlDataAdapter(sqlCommand);

                dataSet = new DataSet();
                adapter.Fill(dataSet);
                studentInfoDataGridView.DataSource = dataSet.Tables[0];
            }
        }

        private void GetFullNameAndClass()
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("spStudents_GetStudent", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(new SqlParameter("@studentId", studentId));                

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        studentInfoLabel.Text = reader.GetString(0) + " " + reader.GetString(1);
                        classStudentInfoLabel.Text = reader.GetString(2);
                    }
                }
            }
        }

        private void StudentInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }
    }
}
