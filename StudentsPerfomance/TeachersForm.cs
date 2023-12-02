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
    public partial class TeachersForm : Form
    {
        private readonly int teacherId;
        private int subjectId;
        DataSet dataSet;
        SqlDataAdapter adapter;
        private SqlCommandBuilder commandBuilder;

        public TeachersForm(int teacherId, bool isClassTeacher)
        {
            InitializeComponent();

            this.teacherId = teacherId;

            if (isClassTeacher)
            {
                tabControl1.TabPages[1].Parent = tabControl1;
                lessonDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                lessonDataGridView.AllowUserToAddRows = false;
                classJournalDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                classJournalDataGridView.AllowUserToAddRows = false;
                AddCmbBoxData("SELECT * FROM Classes ORDER BY className", classLessonCmbBox);
                AddCmbBoxData($"SELECT Classes.id, Classes.className FROM Classes INNER JOIN Teachers ON Classes.classTeacherId = Teachers.id WHERE Teachers.id = {teacherId}", classJournalCmbBox);
                LoadData((int)classLessonCmbBox.SelectedValue, lessonDataGridView);
                LoadData((int)classJournalCmbBox.SelectedValue);
                this.Text = "Журнал классного руководителя";
            }
            else
            {
                tabControl1.TabPages[1].Parent = null;
                lessonDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                lessonDataGridView.AllowUserToAddRows = false;
                AddCmbBoxData("SELECT * FROM Classes ORDER BY className", classLessonCmbBox);
                LoadData((int)classLessonCmbBox.SelectedValue, lessonDataGridView);
                this.Text = "Журнал преподавателя";
            }

            GetFullNameTeacherAndSubject();
        }

        private void LoadData(int classId, DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("spStudentsMarks_GetMarksForSubject", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.Add(new SqlParameter("@subjectId", subjectId));
                sqlCommand.Parameters.Add(new SqlParameter("@classId", classId));
                adapter = new SqlDataAdapter(sqlCommand);

                dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView.DataSource = dataSet.Tables[0];

                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].ReadOnly = true;
                dataGridView.Columns[2].ReadOnly = true;
                dataGridView.Columns[5].Visible = false;
            }
        }

        private void LoadData(int classId)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("spStudentsMarks_GetMarksForAllSubjects", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.Add(new SqlParameter("@classId", classId));
                adapter = new SqlDataAdapter(sqlCommand);

                dataSet = new DataSet();
                adapter.Fill(dataSet);
                classJournalDataGridView.DataSource = dataSet.Tables[0];

                classJournalDataGridView.Columns[0].Visible = true;
                classJournalDataGridView.Columns[1].ReadOnly = true;
                classJournalDataGridView.Columns[2].ReadOnly = true;
                classJournalDataGridView.Columns[5].Visible = true;
            }
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

        private void GetFullNameTeacherAndSubject()
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("spTeachersSubjects_GetSubjectForTeacher", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.Add(new SqlParameter("@teacherId", teacherId));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teacherFullNameLabel.Text = reader.GetString(3) + " " + reader.GetString(1) + " " + reader.GetString(2);
                        subjectNameLabel.Text = reader.GetString(7);
                        subjectId = reader.GetInt32(5);
                    }
                }
            }
        }

        private void deleteLessonBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in lessonDataGridView.SelectedRows)
            {
                using (SqlConnection sqlConnection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("spMarks_DeleteMark", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCommand.Parameters.Add(new SqlParameter("@dateOfIssue", row.Cells[4].Value));
                    sqlCommand.Parameters.Add(new SqlParameter("@studentId", row.Cells[0].Value));
                    sqlCommand.Parameters.Add(new SqlParameter("@subjectId", row.Cells[5].Value));

                    sqlCommand.ExecuteNonQuery();
                }

                lessonDataGridView.Rows.Remove(row);
            }
        }

        private void saveLessonBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter("spStudentsMarks_GetMarksForSubject", connection);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.InsertCommand = new SqlCommand("spMarks_InsertMark", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@dateOfIssue", SqlDbType.Date, 0, "Дата выставления"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@subjectId", SqlDbType.Int, 0, "SubjectId"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@studentId", SqlDbType.Int, 0, "id"));
                    adapter.InsertCommand.Parameters.Add(new SqlParameter("@markName", SqlDbType.Int, 0, "Оценка"));

                    adapter.Update(dataSet);
                }

                MessageBox.Show("Данные сохранены", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException)
            {
                MessageBox.Show("Неверно введена дата или оценка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void addLessonBtn_Click(object sender, EventArgs e)
        {
            LoadData((int)classLessonCmbBox.SelectedValue, lessonDataGridView);
            DataRow row = dataSet.Tables[0].NewRow();
            dataSet.Tables[0].Rows.Add(row);
            AddStudentToClassJournal addStudentTo = new AddStudentToClassJournal((int)classLessonCmbBox.SelectedValue);
            addStudentTo.ShowDialog();
            row[0] = DataBank.Id;
            row[1] = DataBank.LastName;
            row[2] = DataBank.FirstName;
            row[5] = subjectId;
        }

        private void updateLessonBtn_Click(object sender, EventArgs e)
        {
            LoadData((int)classLessonCmbBox.SelectedValue, lessonDataGridView);
        }

        private void TeachersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void classJournalBtn_Click(object sender, EventArgs e)
        {
            LoadData((int)classJournalCmbBox.SelectedValue);
        }
    }
}
