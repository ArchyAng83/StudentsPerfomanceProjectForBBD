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
    public partial class AddGuardianForm : Form
    {
        private int studentId;

        public AddGuardianForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void saveGuardianDataBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                InsertGuardian();
            }
            else
            {
                MessageBox.Show("Неверный ввод данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
        }

        private void InsertGuardian()
        {
            using (SqlConnection sqlConnection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("spGuardians_InsertGuardian", sqlConnection);

                sqlCommand.Parameters.Add(new SqlParameter("@studentId", studentId));
                sqlCommand.Parameters.Add(new SqlParameter("@guardianFullName", lastNameGuardianTextBox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@phone", cellPhoneGuardianTextBox.Text)); 

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.ExecuteNonQuery();
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (lastNameGuardianTextBox.Text.Length < 2)
            {
                output = false;
            }

            if (cellPhoneGuardianTextBox.Text.Length < 5)
            {
                output = false;
            }

            return output;
        }
    }
}
