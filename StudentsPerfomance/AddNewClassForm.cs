using Microsoft.Data.SqlClient;
using StudentsPerformanceLogic;
using StudentsPerformanceLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsPerformance
{
    public partial class AddNewClassForm : Form
    {
        ISchoolClassRequest caller;

        public AddNewClassForm(ISchoolClassRequest caller)
        {
            InitializeComponent();
            this.caller = caller;
        }

        private void saveNewClassBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    SchoolClass schoolClass = new SchoolClass(0, newClassTextBox.Text);

                    schoolClass = GlobalConfig.Connection.CreateClass(schoolClass);

                    caller.SchoolClassComplete(schoolClass);
                }
                catch (System.Data.SqlClient.SqlException)
                {

                    MessageBox.Show("Такой класс уже существует.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный ввод данных.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (newClassTextBox.Text.Trim().Length < 1 || newClassTextBox.Text.Trim().Length > 3)
            {
                output = false;
            }

            return output;
        }
    }
}
