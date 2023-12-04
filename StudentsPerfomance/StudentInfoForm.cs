using Dapper;
using Microsoft.Data.SqlClient;
using StudentsPerfomance;
using StudentsPerformanceLogic;
using StudentsPerformanceLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentsPerformance
{
    public partial class StudentInfoForm : Form
    {
        private int studentId;
        DataSet dataSet;
        SqlDataAdapter adapter;
        List<Subject> availbaleSubjects = new List<Subject>();
        TempStudent student;

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
            LoadSabjectData();
            LoadData();           
        }

        private void LoadSabjectData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                var p = new DynamicParameters();

                availbaleSubjects = connection.Query<Subject>("SELECT * FROM Subjects", p).ToList();
            }

            subjectNameComboBox.DataSource = null;
            subjectNameComboBox.DataSource = availbaleSubjects;
            subjectNameComboBox.DisplayMember = "Name";
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                connection.Open();

                var tempClass = (Subject)subjectNameComboBox.SelectedItem;

                if (tempClass != null)
                {
                    SqlCommand sqlCommand = new SqlCommand("spStudentsMarks_GetAllMarksOfStudent", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCommand.Parameters.Add(new SqlParameter("@studentId", studentId));
                    sqlCommand.Parameters.Add(new SqlParameter("@subjectId", tempClass.Id));
                    adapter = new SqlDataAdapter(sqlCommand);

                    dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    studentInfoDataGridView.DataSource = dataSet.Tables[0];
                }
            }


        }

        private void GetFullNameAndClass()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                //connection.Open();

                //SqlCommand command = new SqlCommand("spStudents_GetStudent", connection)
                //{
                //    CommandType = CommandType.StoredProcedure
                //};
                //command.Parameters.Add(new SqlParameter("@studentId", studentId));                

                //using (SqlDataReader reader = command.ExecuteReader())
                //{
                //    while (reader.Read())
                //    {
                //        studentInfoLabel.Text = reader.GetString(0) + " " + reader.GetString(1);
                //        classStudentInfoLabel.Text = reader.GetString(2);
                //    }
                //}

                var p = new DynamicParameters();

                p.Add("@studentId", studentId);

                student = connection.QueryFirst<TempStudent>("spStudents_GetStudent", p, commandType: CommandType.StoredProcedure);

                p = new DynamicParameters();

                p.Add("@classId", student.ClassId);

                studentInfoLabel.Text = $"{student.LastName} {student.FirstName}";
                var schoolClass = connection.QueryFirst<SchoolClass>("Select className from Classes where Classes.id = @classId", p);
                classStudentInfoLabel.Text = schoolClass.Name;
            }
        }

        private void StudentInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void subjectNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
