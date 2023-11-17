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
    public partial class StudentsForm : Form
    {
        DataSet dataSet;
        SqlDataAdapter adapter;

        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            studentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentsDataGridView.AllowUserToAddRows = false;
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("spStudents_GetAllStudents", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(sqlCommand);

                dataSet = new DataSet();
                adapter.Fill(dataSet);
                studentsDataGridView.DataSource = dataSet.Tables[0];
                // делаем недоступным столбец id для изменения
                studentsDataGridView.Columns[0].ReadOnly = true;
            }
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            AddStudentsForm addStudentsForm = new AddStudentsForm();
            addStudentsForm.ShowDialog();
            LoadData();
        }

        private void updateStudentBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in studentsDataGridView.SelectedRows)
            {
                UpdateStudentsForm updateStudentsForm = new UpdateStudentsForm(row);
                updateStudentsForm.ShowDialog();
            }

            LoadData();
        }

        private void deleteStudentBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in studentsDataGridView.SelectedRows)
            {
                using (SqlConnection sqlConnection = new SqlConnection(GlobalConfig.connectionString))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spStudents_DeleteStudent", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCommand.Parameters.Add(new SqlParameter("@studentId", (int)row.Cells[0].Value));

                    sqlCommand.ExecuteNonQuery();
                }

                studentsDataGridView.Rows.Remove(row);
            }
        }

        private void addGuardianBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in studentsDataGridView.SelectedRows)
            {
                AddGuardianForm addGuardianForm = new AddGuardianForm((int)row.Cells[0].Value);
                addGuardianForm.ShowDialog();
            }            
        }

        private void addFromListLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (DataGridViewRow row in studentsDataGridView.SelectedRows)
            {
                AddGuardianFromListForm addGuardianFromListForm = new AddGuardianFromListForm((int)row.Cells[0].Value);
                addGuardianFromListForm.ShowDialog();
            }
        }

        private void guardiansInfoBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in studentsDataGridView.SelectedRows)
            {
                GuardiansInfoForm guardiansInfoForm = new GuardiansInfoForm((int)row.Cells[0].Value);
                guardiansInfoForm.ShowDialog();
            }
        }

        private void StudentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            HeadTeacherForm headTeacherForm = new HeadTeacherForm();
            this.Hide();
            headTeacherForm.ShowDialog();
        }
    }
}
