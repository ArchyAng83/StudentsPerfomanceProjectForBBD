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
    public partial class AddStudentToClassJournal : Form
    {
        private readonly int classId;
        DataSet dataSet;
        SqlDataAdapter adapter;        

        public AddStudentToClassJournal(int classId)
        {
            InitializeComponent();
            this.classId = classId;
        }

        private void AddStudentToClassJournal_Load(object sender, EventArgs e)
        {
            addStudentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addStudentDataGridView.AllowUserToAddRows = false;
            LoadData();
        }
              
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("spStudentsClasses_GetStudentsOfClass", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                sqlCommand.Parameters.Add(new SqlParameter("@classId", classId));
                adapter = new SqlDataAdapter(sqlCommand);

                dataSet = new DataSet();
                adapter.Fill(dataSet);
                addStudentDataGridView.DataSource = dataSet.Tables[0];
                // делаем недоступным столбец id для изменения
                addStudentDataGridView.Columns[0].ReadOnly = true;
                addStudentDataGridView.Columns[1].ReadOnly = true;
                addStudentDataGridView.Columns[2].ReadOnly = true;
            }
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in addStudentDataGridView.SelectedRows)
            {
                DataBank.Id = (int)row.Cells[0].Value;
                DataBank.FirstName = (string)row.Cells[2].Value;
                DataBank.LastName = (string)row.Cells[1].Value;
            }

            this.Close();
        }
    }
}
