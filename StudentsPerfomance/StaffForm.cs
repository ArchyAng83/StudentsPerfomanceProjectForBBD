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
    public partial class StaffForm : Form
    {
        DataSet dataSet;
        SqlDataAdapter adapter;

        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            staffDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            staffDataGridView.AllowUserToAddRows = false;
            quantityOfStaffLbl.Text = LoadData("COUNT(*)", "Teachers").ToString();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("spTeachers_GetAllTeachers", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                adapter = new SqlDataAdapter(sqlCommand);

                dataSet = new DataSet();
                adapter.Fill(dataSet);
                staffDataGridView.DataSource = dataSet.Tables[0];
                // делаем недоступным столбец id для изменения
                staffDataGridView.Columns[0].ReadOnly = true;
            }
        }

        private int LoadData(string aggrFunction, string targetTable)
        {
            int output = 0;

            using (SqlConnection sqlConnection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand($"SELECT {aggrFunction} FROM {targetTable}", sqlConnection);
                output = (int)sqlCommand.ExecuteScalar();
            }

            return output;
        }

        private void addTeacherBtn_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaffForm = new AddStaffForm();
            addStaffForm.ShowDialog();
            LoadData();
        }

        private void deleteTeacherBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in staffDataGridView.SelectedRows)
            {
                using (SqlConnection sqlConnection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spTeacher_DeleteTeacher", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add(new SqlParameter("@teacherId", (int)row.Cells[0].Value));

                    sqlCommand.ExecuteNonQuery();
                }

                staffDataGridView.Rows.Remove(row);
            }            
        }

        private void updateTeacherBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in staffDataGridView.SelectedRows)
            {
                UpdateStaffForm updateStaffForm = new UpdateStaffForm(row);
                updateStaffForm.ShowDialog();
            }
            
            LoadData();
        }

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }
    }
}
