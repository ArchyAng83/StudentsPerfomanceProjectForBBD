using Dapper;
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
    public partial class StudentInfoForm : Form
    {
        List<Subject> availableSubjects = GlobalConfig.Connection.GetAllSubjects();
        List<SchoolClass> availableClasses = GlobalConfig.Connection.GetAllClasses();
        private readonly int studentId;
        Student currentStudent;

        public StudentInfoForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            subjectNameComboBox.DataSource = null;
            subjectNameComboBox.DataSource = availableSubjects;
            subjectNameComboBox.SelectedIndex = 0;            

            WireUpLists();

        }

        private void WireUpLists()
        {
            SchoolClass schoolClass = availableClasses.Find(sc => sc.Students.Exists(s => s.Id == studentId));
            classNameLbl.Text = schoolClass.Name;
            currentStudent = schoolClass.Students.Find(s => s.Id == studentId);
            studentFullNameLabel.Text = currentStudent.FullName;

            WireUpStudentLists();
        }

        private void WireUpStudentLists()
        {
            Subject subject = (Subject)subjectNameComboBox.SelectedItem;
            studentInfoDataGridView.DataSource = null;
            studentInfoDataGridView.DataSource = currentStudent.Marks.Where(m => m.Subject.Id == subject.Id).ToList();
            studentInfoDataGridView.Columns["Subject"].Visible = false;

            List<Mark> markList = currentStudent.Marks.Where(m => m.Subject.Id == subject.Id).ToList();
            double avgMarks = markList.Count != 0 ? Convert.ToDouble(markList.Sum(x => x.ValueMark)) / markList.Count : 0;
            avgBySubjectLbl.Text = avgMarks.ToString("f2");

            avgMarks = currentStudent.Marks.Count != 0 ? Convert.ToDouble(currentStudent.Marks.Sum(m => m.ValueMark)) / currentStudent.Marks.Count : 0;
            avgAllSubjectsLbl.Text = avgMarks.ToString("f2");
        }

        private void subjectNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentStudent != null)
            {
                WireUpStudentLists();
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
