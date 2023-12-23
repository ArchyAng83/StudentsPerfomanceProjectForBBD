using DGVPrinterHelper;
using Microsoft.Data.SqlClient;
using StudentsPerformanceLogic;
using StudentsPerformanceLogic.Helpers;
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
        List<Subject> availableSubjects = GlobalConfig.Connection.GetAllSubjects();

        public TeachersForm(int teacherId, bool isClassTeacher)
        {
            this.teacherId = teacherId;

            InitializeComponent();            
            
            WireUpLists();            

            if (isClassTeacher)
            {
                teacherTabControl.TabPages[1].Parent = teacherTabControl;
                lessonMarksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                lessonMarksDataGridView.AllowUserToAddRows = false;
            }
            else
            {
                teacherTabControl.TabPages[1].Parent = null;
                lessonMarksDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                lessonMarksDataGridView.AllowUserToAddRows = false;
            }
        }

        private void WireUpLists()
        {
            markComboBox.SelectedIndex = 0;

            classLessonCmbBox.DataSource = null;
            classLessonCmbBox.DataSource = availableClasses;
            classLessonCmbBox.DisplayMember = "Name";

            lessonStudentsDataGridView.ReadOnly = true;
            lessonStudentsDataGridView.AllowUserToAddRows = false;
            lessonStudentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            classJournalStudentsDataGridView.ReadOnly = true;
            classJournalStudentsDataGridView.AllowUserToAddRows = false;
            classJournalStudentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            currentTeacher = GlobalConfig.Connection.GetTeacher(teacherId);
            currentTeacher.SchoolClass.Students = availableClasses.Where(c => c.Id == currentTeacher.SchoolClass.Id).Select(s => s.Students).FirstOrDefault();

            subjectCmbBox.DataSource = null;
            subjectCmbBox.DataSource = availableSubjects;
            subjectCmbBox.DisplayMember = "Name";
            subjectCmbBox.SelectedIndex = 0;

            classValueLabel.Text = currentTeacher.SchoolClass.Name;
            classTeacherFullNameLbl.Text = currentTeacher.FullName;

            teacherFullNameLabel.Text = currentTeacher.FullName;
            subjectNameLbl.Text = currentTeacher.Subject.Name;
            wireUpStudentCJLists();
        }

        private void wireUpStudentCJLists()
        {
            if (currentTeacher.SchoolClass != null)
            {
                classJournalStudentsDataGridView.DataSource = null;
                classJournalStudentsDataGridView.DataSource = currentTeacher.SchoolClass.Students;
                classJournalStudentsDataGridView.Columns["FullName"].Visible = false;
                classJournalStudentsDataGridView.Columns["Id"].Visible = false;
                classJournalStudentsDataGridView.Columns["MiddleName"].Visible = false;
                classJournalStudentsDataGridView.Columns["Address"].Visible = false;
                classJournalStudentsDataGridView.Columns["BirthDate"].Visible = false;
                classJournalStudentsDataGridView.Columns["CellPhone"].Visible = false;
            }
        }

        private void WireUpStudentLists()
        {
            lessonStudentsDataGridView.DataSource = null;
            lessonStudentsDataGridView.DataSource = availableStudents.GetRange(0, availableStudents.Count);
            lessonStudentsDataGridView.Columns["FullName"].Visible = false;

            lessonStudentsDataGridView.Columns["Id"].Visible = false;
            lessonStudentsDataGridView.Columns["MiddleName"].Visible = false;
            lessonStudentsDataGridView.Columns["Address"].Visible = false;
            lessonStudentsDataGridView.Columns["BirthDate"].Visible = false;
            lessonStudentsDataGridView.Columns["CellPhone"].Visible = false;
        }

        private void WireUpMarkLists()
        {
            List<Mark> markList = currentStudent.Marks.Where(m => m.Subject.Id == currentTeacher.Subject.Id).ToList();
            double avgMarks = markList.Count != 0 ? Convert.ToDouble(markList.Sum(x => x.ValueMark)) / markList.Count : 0;
            avgSubjectLbl.Text = avgMarks.ToString("f2");

            lessonMarksDataGridView.DataSource = null;
            lessonMarksDataGridView.DataSource = markList;
            lessonMarksDataGridView.Columns["Subject"].Visible = false;            
        }

        private void WireUpMarkCJLists()
        {
            Subject selectedSubject = (Subject)subjectCmbBox.SelectedItem;
            List<Mark> markList = currentStudent.Marks.Where(m => m.Subject.Id == selectedSubject.Id).ToList();
            double avgMarks = markList.Count != 0 ? Convert.ToDouble(markList.Sum(x => x.ValueMark)) / markList.Count : 0;
            avgBySubjectLbl.Text = avgMarks.ToString("f2");

            avgMarks = currentStudent.Marks.Count != 0 ? Convert.ToDouble(currentStudent.Marks.Sum(m => m.ValueMark)) / currentStudent.Marks.Count : 0;
            avgAllSubjectsValue.Text = avgMarks.ToString("f2");

            classJournalMarksDataGridView.DataSource = null;
            classJournalMarksDataGridView.DataSource = markList;
            classJournalMarksDataGridView.Columns["Subject"].Visible = false;           
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

        private void lessonStudentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentStudent = (Student)lessonStudentsDataGridView.SelectedRows[0].DataBoundItem;
            if (currentStudent != null)
            {
                WireUpMarkLists();
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
                MessageBox.Show("Разрешено ставить только одну оценку в день по данному предмету", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateMarkLessonBtn_Click(object sender, EventArgs e)
        {
            if (currentStudent != null)
            {
                Mark mark;

                if (currentStudent.Marks.Count > 0)
                {
                    mark = (Mark)lessonMarksDataGridView.SelectedRows[0].DataBoundItem;

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
                    mark = (Mark)lessonMarksDataGridView.SelectedRows[0].DataBoundItem;

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

        #region Class Journal page

        private void classJournalStudentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentStudent = (Student)classJournalStudentsDataGridView.SelectedRows[0].DataBoundItem;
            if (currentStudent != null)
            {
                WireUpMarkCJLists();
            }
        }

        private void subjectCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentStudent != null)
            {
                WireUpMarkCJLists();
            }
        }        

        private void printStudentAVGBallBtn_Click(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();

            if (currentStudent != null)
            {
                List<SubjectAvgHelper> subjectAvgs = GlobalConfig.Connection.GetAvgByStudent(currentStudent.Id);
                                
                this.Controls.Add(dgv);
                dgv.DataSource = subjectAvgs;
                dgv.DefaultCellStyle.Font = new Font("Arial", 16);
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16);
            }
            else
            {
                MessageBox.Show("Не выбран учащийся", "Ошибка выбранных данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Отчет по среднему баллу учащегося";
            printer.SubTitle = GetStringToTitle();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = DateTime.UtcNow.ToShortDateString();
            printer.PreviewDialog = printPreviewDialog1;
            printer.PrintPreviewDataGridView(dgv);
        }

        private string GetStringToTitle()
        {
            StringBuilder sb = new StringBuilder();

            if (currentStudent != null)
            {
                sb.AppendLine($"{currentStudent.FullName}");
                sb.AppendLine($"{currentTeacher.SchoolClass.Name} класс");
                sb.AppendLine($"{avgAllSubjectsText.Text} {avgAllSubjectsValue.Text}"); 
            }
            else
            {
                MessageBox.Show("Не выбран учащийся", "Ошибка выбранных данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sb.ToString();
        }
        #endregion
    }
}
