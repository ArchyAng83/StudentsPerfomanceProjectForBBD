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
    //Todo: selected teacher view
    public partial class HeadTeacherForm : Form, ISchoolClassRequest, IGuardianRequest, ISubjectRequest
    {
        readonly List<SchoolClass> availableClasses = GlobalConfig.Connection.GetAllClasses();
        List<Guardian> selectedGuardians = new List<Guardian>();
        List<Student> availableStudents = new List<Student>();
        Student currentStudent;
        SchoolClass oldClass;
        List<Subject> availableSubjects = GlobalConfig.Connection.GetAllSubjects();
        List<Teacher> availableTeachers = GlobalConfig.Connection.GetAllTeachers();
        Teacher selectedTeacher;

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
            subjectCmbBox.DataSource = availableSubjects;
            subjectCmbBox.DisplayMember = "Name";

            classNameForTeacherComboBox.DataSource = null;
            classNameForTeacherComboBox.DataSource = availableClasses;
            classNameForTeacherComboBox.DisplayMember = "Name";
                        
            WireUpTeacherLists();
        }

        private void WireUpTeacherLists()
        {
            teachersDataGridView.DataSource = null;
            teachersDataGridView.DataSource = availableTeachers.GetRange(0, availableTeachers.Count);
            teachersDataGridView.Columns["FullName"].Visible = false;

            teachersDataGridView.AllowUserToAddRows = false;
            teachersDataGridView.ReadOnly = true;
            teachersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            teachersDataGridView.Columns["Subject"].DisplayIndex = teachersDataGridView.Columns.Count - 1;
            teachersDataGridView.Columns["SchoolClass"].DisplayIndex = teachersDataGridView.Columns.Count - 1;

            quantityOfStaffLbl.Text = availableTeachers.Count.ToString();
        }

        private void WireUpStudentLists()
        {
            WireUpGuardianLists();

            studentsDataGridView.DataSource = null;
            studentsDataGridView.DataSource = availableStudents.GetRange(0, availableStudents.Count);
            studentsDataGridView.Columns["FullName"].Visible = false;

            quantityOfStudentsLbl.Text = GlobalConfig.Connection.GetStudentsCount().ToString();
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
            if (ValidateStudentPage())
            {
                SchoolClass schoolClass = (SchoolClass)classStudentCmbBox.SelectedItem;
                string cellPhoneNumber = cellPhoneStudentTextBox.Text == string.Empty ? null : cellPhoneStudentTextBox.Text;
                Student student = new Student(0, lastNameStudentTextBox.Text, firstNameStudentTextBox.Text, middleNameStudentTextBox.Text, adressStudentTextBox.Text,
                                                  birthDateSturdentTimePicker.Value, cellPhoneNumber);
                student.Guardians = selectedGuardians;

                try
                {
                    student = GlobalConfig.Connection.AddStudent(student, schoolClass.Id);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Опекуны должны быть разными", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                

                availableStudents.Add(student);

                ClearStudentSetup();
                WireUpStudentLists();
            }
            else
            {
                MessageBox.Show("Неверный ввод данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            ClearStudentSetup();
            WireUpStudentLists();
        }

        private void updateStudentBtn_Click(object sender, EventArgs e)
        {
            if (ValidateStudentPage())
            {
                if (currentStudent != null)
                {
                    SchoolClass schoolClass = (SchoolClass)classStudentCmbBox.SelectedItem;
                    string cellPhoneNumber = cellPhoneStudentTextBox.Text == string.Empty ? null : cellPhoneStudentTextBox.Text;
                    Student newStudent = new Student(currentStudent.Id, lastNameStudentTextBox.Text, firstNameStudentTextBox.Text, middleNameStudentTextBox.Text, adressStudentTextBox.Text,
                                                      birthDateSturdentTimePicker.Value, cellPhoneNumber);
                    newStudent.Guardians = currentStudent.Guardians;

                    try
                    {
                        GlobalConfig.Connection.UpdateStudent(newStudent, schoolClass.Id);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("Опекуны должны быть разными", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    oldClass.Students.Remove(currentStudent);
                    availableStudents.Remove(currentStudent);
                    availableStudents.Add(newStudent);

                    ClearStudentSetup();
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
                birthDateSturdentTimePicker.Value = currentStudent.BirthDate;
                cellPhoneStudentTextBox.Text = currentStudent.CellPhone?.ToString();
                selectedGuardians = currentStudent.Guardians;
            }

            WireUpGuardianLists();
        }

        private void ClearStudentSetup()
        {
            lastNameStudentTextBox.Text = string.Empty;
            firstNameStudentTextBox.Text = string.Empty;
            middleNameStudentTextBox.Text = string.Empty;
            adressStudentTextBox.Text = string.Empty;
            birthDateSturdentTimePicker.Value = DateTime.UtcNow;
            cellPhoneStudentTextBox.Text = string.Empty;
            selectedGuardians = null;
        }

        private bool ValidateStudentPage()
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

        private void addTeacherBtn_Click(object sender, EventArgs e)
        {
            if (ValidateTeacherPage())
            {
                Subject selectedSubject = (Subject)subjectCmbBox.SelectedItem;
                SchoolClass selectedClass = classTeacherChckBox.Checked ? (SchoolClass)classNameForTeacherComboBox.SelectedItem : null;
                string cellPhoneNumber = cellPhoneTeacherTextBox.Text == string.Empty ? null : cellPhoneTeacherTextBox.Text;
                Teacher teacher = new Teacher(0, lastNameTeacherTextBox.Text, firstNameTeacherTextBox.Text, middleNameTeacherTextBox.Text,
                                                 addressTeacherTextBox.Text, birthDateTeacherTimePicker.Value, cellPhoneNumber, selectedSubject, selectedClass);
                teacher = GlobalConfig.Connection.AddTeacher(teacher);

                availableTeachers.Add(teacher);

                ClearTeacherSetup();
            }
            else
            {
                MessageBox.Show("Неверный ввод данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            WireUpTeacherLists();
        }

        private void updateTeacherBtn_Click(object sender, EventArgs e)
        {
            if (ValidateTeacherPage())
            {
                if (availableTeachers.Count > 0)
                {
                    selectedTeacher = (Teacher)teachersDataGridView.SelectedRows[0].DataBoundItem;
                    Subject selectedSubject = (Subject)subjectCmbBox.SelectedItem;
                    SchoolClass selectedClass = classTeacherChckBox.Checked ? (SchoolClass)classNameForTeacherComboBox.SelectedItem : null;
                    string cellPhoneNumber = cellPhoneTeacherTextBox.Text == string.Empty ? null : cellPhoneTeacherTextBox.Text;
                    Teacher newTeacher = new Teacher(selectedTeacher.Id, lastNameTeacherTextBox.Text, firstNameTeacherTextBox.Text, middleNameTeacherTextBox.Text,
                                                 addressTeacherTextBox.Text, birthDateTeacherTimePicker.Value, cellPhoneNumber, selectedSubject, selectedClass);

                    GlobalConfig.Connection.UpdateTeacher(newTeacher);

                    availableTeachers.Remove(selectedTeacher);
                    availableTeachers.Add(newTeacher);

                    ClearTeacherSetup();
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

            WireUpTeacherLists();
        }

        private void deleteTeacherBtn_Click(object sender, EventArgs e)
        {
            if (availableTeachers.Count > 0)
            {
                selectedTeacher = (Teacher)teachersDataGridView.SelectedRows[0].DataBoundItem;

                GlobalConfig.Connection.DeleteTeacher(selectedTeacher.Id);

                availableTeachers.Remove(selectedTeacher);
            }

            ClearTeacherSetup();
            WireUpTeacherLists();
        }

        private void teachersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (availableTeachers.Count > 0)
            {
                selectedTeacher = (Teacher)teachersDataGridView.SelectedRows[0].DataBoundItem;
                lastNameTeacherTextBox.Text = selectedTeacher.LastName;
                firstNameTeacherTextBox.Text = selectedTeacher.FirstName;
                middleNameTeacherTextBox.Text = selectedTeacher.MiddleName;
                addressTeacherTextBox.Text = selectedTeacher.Address;
                birthDateTeacherTimePicker.Value = selectedTeacher.BirthDate;
                cellPhoneTeacherTextBox.Text = selectedTeacher.CellPhone?.ToString();
                subjectCmbBox.SelectedItem = selectedTeacher.Subject;
                classNameForTeacherComboBox.SelectedItem = selectedTeacher.SchoolClass ?? classNameForTeacherComboBox.Items[0];
                classTeacherChckBox.Checked = selectedTeacher.SchoolClass != null;
            }
        }

        private bool ValidateTeacherPage()
        {
            bool output = true;

            if (lastNameTeacherTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (firstNameTeacherTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (middleNameTeacherTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (addressTeacherTextBox.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }

        private void ClearTeacherSetup()
        {
            lastNameTeacherTextBox.Text = string.Empty;
            firstNameTeacherTextBox.Text = string.Empty;
            middleNameTeacherTextBox.Text = string.Empty;
            addressTeacherTextBox.Text = string.Empty;
            birthDateTeacherTimePicker.Value = DateTime.UtcNow;
            cellPhoneTeacherTextBox.Text = string.Empty;
            classTeacherChckBox.Checked = false;
        }
        #endregion

        #region Reports page functional


        //Todo: add reports

        #endregion
    }
}
