using Microsoft.Data.SqlClient;
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

namespace StudentsPerformance
{
    public partial class TeachersForm : Form
    {
        private readonly int teacherId;
        List<SchoolClass> availableClasses = GlobalConfig.Connection.GetAllClasses();
        List<Student> availableStudents = new List<Student>();
        Teacher currentTeacher;
        Student currentStudent;

        public TeachersForm(int teacherId, bool isClassTeacher)
        {
            this.teacherId = teacherId;

            InitializeComponent();            
            
            WireUpLists();

            markComboBox.SelectedIndex = 0;

            if (isClassTeacher)
            {
                tabControl1.TabPages[1].Parent = tabControl1;
                lessonDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                lessonDataGridView.AllowUserToAddRows = false;
                classJournalDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                classJournalDataGridView.AllowUserToAddRows = false;
            }
            else
            {
                tabControl1.TabPages[1].Parent = null;
                lessonDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                lessonDataGridView.AllowUserToAddRows = false;
            }
        }

        private void WireUpLists()
        {
            classLessonCmbBox.DataSource = null;
            classLessonCmbBox.DataSource = availableClasses;
            classLessonCmbBox.DisplayMember = "Name";

            classStudentsDataGridView.ReadOnly = true;
            classStudentsDataGridView.AllowUserToAddRows = false;
            classStudentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            currentTeacher = GlobalConfig.Connection.GetTeacher(teacherId);
            
            teacherFullNameLabel.Text = currentTeacher.FullName;
            subjectNameLbl.Text = currentTeacher.Subject.Name;
        }

        private void WireUpStudentLists()
        {
            classStudentsDataGridView.DataSource = null;
            classStudentsDataGridView.DataSource = availableStudents.GetRange(0, availableStudents.Count);
            classStudentsDataGridView.Columns["FullName"].Visible = false;

            classStudentsDataGridView.Columns["Id"].Visible = false;
            classStudentsDataGridView.Columns["MiddleName"].Visible = false;
            classStudentsDataGridView.Columns["Address"].Visible = false;
            classStudentsDataGridView.Columns["BirthDate"].Visible = false;
            classStudentsDataGridView.Columns["CellPhone"].Visible = false;
        }

        private void WireUpMarkLists()
        {
            lessonDataGridView.DataSource = null;
            lessonDataGridView.DataSource = currentStudent.Marks;
            lessonDataGridView.Columns["Subject"].Visible = false;
        }

        #region Lesson's page

        private void classLessonCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SchoolClass schoolClass = (SchoolClass)classLessonCmbBox.SelectedItem;

            if (schoolClass != null)
            {
                availableStudents = schoolClass.Students;
            }

            WireUpStudentLists();
        }

        private void TeachersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void classStudentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentStudent = (Student)classStudentsDataGridView.SelectedRows[0].DataBoundItem;
            if (currentStudent != null)
            {
                lessonDataGridView.DataSource = currentStudent.Marks;
                lessonDataGridView.Columns["Subject"].Visible = false;
            }
        }

        private void addLessonBtn_Click(object sender, EventArgs e)
        {
            int selectedMark = int.Parse(markComboBox.Text);
            Mark mark;

            try
            {
                if (currentStudent != null)
                {
                    mark = new Mark(DateTime.UtcNow, currentTeacher.Subject, selectedMark);
                    GlobalConfig.Connection.AddMarkToStudent(mark, currentStudent.Id);
                    currentStudent.Marks.Add(mark);

                    WireUpMarkLists();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Разрешено ставить только одну оценку в день по предмету", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateMarkLessonBtn_Click(object sender, EventArgs e)
        {
            if (currentStudent != null)
            {
                Mark mark;

                if (currentStudent.Marks.Count > 0)
                {
                    mark = (Mark)lessonDataGridView.SelectedRows[0].DataBoundItem;

                    int selectedMark = int.Parse(markComboBox.Text);
                    Mark newMark = new Mark(mark.DateOfIssue, currentTeacher.Subject, selectedMark);

                    GlobalConfig.Connection.UpdateMarkToStudent(newMark, currentStudent.Id);
                    currentStudent.Marks.Remove(mark);
                    currentStudent.Marks.Add(newMark);

                    WireUpMarkLists();
                }                
            }
            else
            {
                MessageBox.Show("Не выбран учащийся", "Ошибка выбранных данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteMarkLessonBtn_Click(object sender, EventArgs e)
        {
            if (currentStudent != null)
            {
                Mark mark;

                if (currentStudent.Marks.Count > 0)
                {
                    mark = (Mark)lessonDataGridView.SelectedRows[0].DataBoundItem;

                    GlobalConfig.Connection.DeleteMarkToStudent(mark, currentStudent.Id);
                    currentStudent.Marks.Remove(mark);
                    WireUpMarkLists();
                }
            }
            else
            {
                MessageBox.Show("Не выбран учащийся", "Ошибка выбранных данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
