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
    public partial class HeadTeacherForm : Form, ISchoolClassRequest, IGuardianRequest
    {
        readonly List<SchoolClass> availableClasses = GlobalConfig.Connection.GetAllClasses();
        readonly List<Guardian> availableGuardians = new List<Guardian>();

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

            guardiansListBox.DataSource = null;
            guardiansListBox.DataSource = availableGuardians;
            guardiansListBox.DisplayMember = "FullName";
        }

        private void HeadTeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

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
            availableGuardians.Add(guardian);
            WireUpLists();
        }
    }
}
