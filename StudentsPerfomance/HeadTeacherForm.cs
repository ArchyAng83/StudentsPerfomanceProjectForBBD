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
    public partial class HeadTeacherForm : Form, ISchoolClassRequest, IGuardianRequest, ISubjectRequest
    {
        readonly List<SchoolClass> availableClasses = GlobalConfig.Connection.GetAllClasses();
        List<Guardian> selectedGuardians = new List<Guardian>();
        List<Student> availableStudents = new List<Student>();
        Student currentStudent;
        SchoolClass oldClass;
        List<Subject> availableSubjects = GlobalConfig.Connection.GetAllSubjects();

        public HeadTeacherForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            classStudentCmbBox.DataSource = null;
            classStudentCmbBox.DataSource = availableClasses;
            classStudentCmbBox.DisplayMember = "Name";

            studentsDataGridView.AllowUserToAddRows = false;
            studentsDataGridView.ReadOnly = true;
            studentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            subjectCmbBox.DataSource = null;
            subjectCmbBox.DataSource= availableSubjects;
            subjectCmbBox.DisplayMember = "Name";

            classNameForTeacherComboBox.DataSource = null;
            classNameForTeacherComboBox.DataSource = availableClasses;
            classNameForTeacherComboBox.DisplayMember = "Name";

            teachersDataGridView.AllowUserToAddRows = false;
            teachersDataGridView.ReadOnly = true;
            teachersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            quantityOfStaffLbl.Text = "1";
        }

        private void WireUpStudentLists()
        {
            WireUpGuardianLists();

            studentsDataGridView.DataSource = null;
            studentsDataGridView.DataSource = availableStudents.GetRange(0, availableStudents.Count);
            studentsDataGridView.Columns["FullName"].Visible = false;
        }

        private void WireUpGuardianLists()
        {
            guardiansListBox.DataSource = null;
            guardiansListBox.DataSource = selectedGuardians;
            guardiansListBox.DisplayMember = "FullName";
        }

        private void HeadTeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }
        #region Student's page functional
        private void addNewClassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewClassForm newClassForm = new AddNewClassForm(this);
            newClassForm.ShowDialog();
        }

        public void SchoolClassComplete(SchoolClass schoolClass)
        {
            availableClasses.Add(schoolClass);
            WireUpLists();
        }

        private void editGuardiansLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddGuardianForm guardianForm = new AddGuardianForm(this);
            guardianForm.ShowDialog();
        }

        public void GuardianComplete(Guardian guardian)
        {
            selectedGuardians.Add(guardian);
            if (currentStudent != null)
            {
                currentStudent.Guardians = selectedGuardians;
            }
            
            WireUpStudentLists();
        }

        private void removeGuardianBtn_Click(object sender, EventArgs e)
        {
            Guardian guardian = (Guardian)guardiansListBox.SelectedItem;
            if (guardian != null)
            {
                selectedGuardians.Remove(guardian);
                if (currentStudent != null)
                {
                    currentStudent.Guardians = selectedGuardians;
                }
                WireUpStudentLists();
            }
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SchoolClass schoolClass = (SchoolClass)classStudentCmbBox.SelectedItem;
                string cellPhoneNumber = cellPhoneStudentTextBox.Text == string.Empty ? null : cellPhoneStudentTextBox.Text;
                Student student = new Student(0, lastNameStudentTextBox.Text, firstNameStudentTextBox.Text, middleNameStudentTextBox.Text, adressStudentTextBox.Text,
                                                  dateOfBirthTimePicker.Value, cellPhoneNumber);

                student.Guardians = selectedGuardians;

                student = GlobalConfig.Connection.AddStudent(student, schoolClass.Id);

                availableStudents.Add(student);

                WireUpStudentLists();
            }
            else
            {
                MessageBox.Show("Неверный ввод данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidateForm()
        {
            bool output = true;

            if (lastNameStudentTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (firstNameStudentTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (middleNameStudentTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (adressStudentTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (selectedGuardians.Count < 1 || selectedGuardians.Count > 2)
            {
                output = false;
            }

            return output;
        }

        private void deleteStudentBtn_Click(object sender, EventArgs e)
        {
            if (currentStudent != null)
            {
                Student student = (Student)studentsDataGridView.SelectedRows[0].DataBoundItem;

                GlobalConfig.Connection.DeleteStudent(student.Id);

                availableStudents.Remove(student);
            }
            else
            {
                MessageBox.Show("Не выбран учащийся", "Ошибка выбранных данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            WireUpStudentLists();
        }

        private void updateStudentBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (currentStudent != null)
                {
                    SchoolClass schoolClass = (SchoolClass)classStudentCmbBox.SelectedItem;
                    string cellPhoneNumber = cellPhoneStudentTextBox.Text == string.Empty ? null : cellPhoneStudentTextBox.Text;
                    Student newStudent = new Student(currentStudent.Id, lastNameStudentTextBox.Text, firstNameStudentTextBox.Text, middleNameStudentTextBox.Text, adressStudentTextBox.Text,
                                                      dateOfBirthTimePicker.Value, cellPhoneNumber);
                    newStudent.Guardians = currentStudent.Guardians;

                    GlobalConfig.Connection.UpdateStudent(newStudent, schoolClass.Id);

                    oldClass.Students.Remove(currentStudent);
                    availableStudents.Remove(currentStudent);
                    availableStudents.Add(newStudent);

                    WireUpStudentLists();
                }
                else
                {
                    MessageBox.Show("Не выбран учащийся", "Ошибка выбранных данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else
            {
                MessageBox.Show("Неверный ввод данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void classStudentCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SchoolClass schoolClass = (SchoolClass)classStudentCmbBox.SelectedItem;

            if (schoolClass != null)
            {
                availableStudents = schoolClass.Students; 
            }

            WireUpStudentLists();
        }

        private void studentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (availableStudents.Count > 0)
            {
                currentStudent = (Student)studentsDataGridView.SelectedRows[0].DataBoundItem;
                oldClass = (SchoolClass)classStudentCmbBox.SelectedItem;
                lastNameStudentTextBox.Text = currentStudent.LastName;
                firstNameStudentTextBox.Text = currentStudent.FirstName;
                middleNameStudentTextBox.Text = currentStudent.MiddleName;
                adressStudentTextBox.Text = currentStudent.Address;
                dateOfBirthTimePicker.Text = currentStudent.BirthDate.ToString();
                cellPhoneStudentTextBox.Text = currentStudent.CellPhone?.ToString();
                selectedGuardians = currentStudent.Guardians;
            }

            WireUpGuardianLists();
        }
        #endregion

        #region Teacher's page functional
        private void addNewSubjectLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddSubjectForm subjectForm = new AddSubjectForm(this);
            subjectForm.ShowDialog();
        }

        public void SubjectComplete(Subject subject)
        {
            availableSubjects.Add(subject);
            WireUpLists();
        }
        #endregion


    }
}
