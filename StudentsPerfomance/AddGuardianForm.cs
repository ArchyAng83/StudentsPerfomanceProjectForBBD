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
    public partial class AddGuardianForm : Form
    {
        List<Guardian> availableGuardians = GlobalConfig.Connection.GetAllGuardians();
        IGuardianRequest caller;

        public AddGuardianForm(IGuardianRequest caller)
        {
            InitializeComponent();
            guardiansDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            guardiansDataGridView.AllowUserToAddRows = false;

            WireUpLists();
            this.caller = caller;
        }

        private void WireUpLists()
        {
            guardiansDataGridView.DataSource = null;
            guardiansDataGridView.DataSource = availableGuardians.GetRange(0, availableGuardians.Count);
            guardiansDataGridView.Columns["Id"].Visible = false;
            guardiansDataGridView.Columns["FullName"].Visible = false;
        }

        private void ClearSetup()
        {
            lastNameGuardianTextBox.Text = string.Empty;
            firstNameGuardianTextBox.Text = string.Empty;
            middleNameGuardianTextBox.Text = string.Empty;
            addressGuardianTextBox.Text = string.Empty;
            dateOfBirthGuardianTimePicker.Value = DateTime.UtcNow;
            cellPhoneGuardianTextBox.Text = string.Empty;
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (lastNameGuardianTextBox.Text.Length == 0)
            { 
                output = false;
            }

            if (firstNameGuardianTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (middleNameGuardianTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (addressGuardianTextBox.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }

        private void guardiansDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (availableGuardians.Count > 0)
            {
                Guardian guardian = (Guardian)guardiansDataGridView.SelectedRows[0].DataBoundItem;

                lastNameGuardianTextBox.Text = guardian.LastName.ToString();
                firstNameGuardianTextBox.Text = guardian.FirstName.ToString();
                middleNameGuardianTextBox.Text = guardian.MiddleName.ToString();
                addressGuardianTextBox.Text = guardian.Address.ToString();
                dateOfBirthGuardianTimePicker.Text = guardian.BirthDate.ToString();
                cellPhoneGuardianTextBox.Text = guardian.CellPhone?.ToString();
            }
        }

        private void addGuardianBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                string cellPhoneNumber = cellPhoneGuardianTextBox.Text == string.Empty ? null : cellPhoneGuardianTextBox.Text;
                Guardian guardian = new Guardian(0, lastNameGuardianTextBox.Text, firstNameGuardianTextBox.Text, middleNameGuardianTextBox.Text, 
                                                    addressGuardianTextBox.Text, dateOfBirthGuardianTimePicker.Value, cellPhoneNumber);
                guardian = GlobalConfig.Connection.AddGuardian(guardian);                
                availableGuardians.Add(guardian);
                ClearSetup();
                WireUpLists();
               
            }
            else
            {
                MessageBox.Show("Неверный ввод данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateGuardianBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (availableGuardians.Count > 0)
                {
                    Guardian guardian = (Guardian)guardiansDataGridView.SelectedRows[0].DataBoundItem;
                    string cellPhoneNumber = cellPhoneGuardianTextBox.Text == string.Empty ? null : cellPhoneGuardianTextBox.Text;
                    Guardian newGuardian = new Guardian(guardian.Id, lastNameGuardianTextBox.Text, firstNameGuardianTextBox.Text, middleNameGuardianTextBox.Text,
                                                        addressGuardianTextBox.Text, dateOfBirthGuardianTimePicker.Value, cellPhoneNumber);

                    GlobalConfig.Connection.UpdateGuardian(newGuardian);

                    int index = availableGuardians.FindIndex(x => x.Id == newGuardian.Id);
                    availableGuardians[index] = newGuardian;
                }

                WireUpLists();
            }
            else
            {
                MessageBox.Show("Неверный ввод данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteGuardianBtn_Click(object sender, EventArgs e)
        {
            
            if (availableGuardians.Count > 0)
            {
                Guardian guardian = (Guardian)guardiansDataGridView.SelectedRows[0].DataBoundItem;
                GlobalConfig.Connection.DeleteGuardian(guardian.Id);
                availableGuardians.Remove(guardian);
                ClearSetup();
            }

            WireUpLists();
        }

        private void addGuardianToStudentBtn_Click(object sender, EventArgs e)
        {
            Guardian guardian = (Guardian)guardiansDataGridView.SelectedRows[0].DataBoundItem;

            caller.GuardianComplete(guardian);
        }
    }
}
