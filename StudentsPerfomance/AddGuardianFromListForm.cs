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

namespace StudentsPerfomance
{
    public partial class AddGuardianFromListForm : Form
    {
        DataSet dataSet;
        SqlDataAdapter adapter;
        private int studentId;

        public AddGuardianFromListForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void AddGuardianFromListForm_Load(object sender, EventArgs e)
        {
            guardiansDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            guardiansDataGridView.AllowUserToAddRows = false;
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("spGuardians_GetAllGuardians", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(sqlCommand);

                dataSet = new DataSet();
                adapter.Fill(dataSet);
                guardiansDataGridView.DataSource = dataSet.Tables[0];

                guardiansDataGridView.Columns[0].ReadOnly = true;
                guardiansDataGridView.Columns[1].ReadOnly = true;
                guardiansDataGridView.Columns[2].ReadOnly = true;
            }
        }

        private void addGuardianFromListBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in guardiansDataGridView.SelectedRows)
            {
                using (SqlConnection connection = new SqlConnection(GlobalConfig.connectionString))
                {
                    connection.Open();

                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand("INSERT INTO Guardians_Students VALUES (@studentId, @guardianId)", connection);
                        sqlCommand.Parameters.Add(new SqlParameter("@studentId", studentId));
                        sqlCommand.Parameters.Add(new SqlParameter("@guardianId", (int)row.Cells[0].Value));

                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Такой опекун существует у данного учащегося", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            this.Hide();
        }
    }
}
