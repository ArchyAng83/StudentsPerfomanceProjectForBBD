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
    public partial class GuardiansInfoForm : Form
    {
        private int studentId;
        DataSet dataSet;
        SqlDataAdapter adapter;

        public GuardiansInfoForm(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void GuardiansInfoForm_Load(object sender, EventArgs e)
        {
            guardiansInfoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            guardiansInfoDataGridView.AllowUserToAddRows = false;
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("spGuardiansStudent_GetGuardians", connection);
                sqlCommand.Parameters.Add(new SqlParameter("@studentId", studentId));
                sqlCommand.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(sqlCommand);

                dataSet = new DataSet();
                adapter.Fill(dataSet);
                guardiansInfoDataGridView.DataSource = dataSet.Tables[0];
            }
        }
    }
}
