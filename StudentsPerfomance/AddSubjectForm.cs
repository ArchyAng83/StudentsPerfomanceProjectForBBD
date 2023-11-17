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
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void saveSubjectBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                using (SqlConnection sqlConnection = new SqlConnection(GlobalConfig.connectionString))
                {
                    sqlConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Subjects(name) VALUES (@name)", sqlConnection);
                    sqlCommand.Parameters.Add(new SqlParameter("@name", newSubjectTextBox.Text));

                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Данные сохранены", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Неверный ввод данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (newSubjectTextBox.Text.Length <= 1)
            {
                output = false;
                
            }

            return output;
        }
    }
}
