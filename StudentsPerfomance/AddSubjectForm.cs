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
    public partial class AddSubjectForm : Form
    {
        ISubjectRequest caller;

        public AddSubjectForm(ISubjectRequest caller)
        {
            InitializeComponent();
            this.caller = caller;
        }

        private void saveSubjectBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    Subject subject = new Subject(0, newSubjectTextBox.Text);

                    subject = GlobalConfig.Connection.CreateSubject(subject);

                    caller.SubjectComplete(subject);
                }
                catch (System.Data.SqlClient.SqlException)
                {

                    MessageBox.Show("Такой предмет уже существует.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный ввод данных", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (newSubjectTextBox.Text.Length == 0)
            {
                output = false;
                
            }

            return output;
        }
    }
}
