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
    public partial class ReportsForm : Form
    {
        DataSet dataSet;
        SqlDataAdapter adapter;

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            quantityOfStudentsLbl.Text = LoadData("COUNT(*)", "Students").ToString();
            
            avgSchoolLbl.Text = LoadData("AVG(name)", "Marks").ToString();
        }

        private int LoadData(string aggrFunction, string targetTable)
        {
            int output = 0;

            using (SqlConnection sqlConnection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand($"SELECT {aggrFunction} FROM {targetTable}", sqlConnection);
                output = (int)sqlCommand.ExecuteScalar();
            }

            return output;
        }

        private void avgMarkSubjectBtn_Click(object sender, EventArgs e)
        {
            GetAvgMarks("spAVG_AverangMarkSubject");
        }        

        private void avgMarkClassBtn_Click(object sender, EventArgs e)
        {
            GetAvgMarks("sp_AVG_AverangMarkClass");
        }

        private void GetAvgMarks(string sqlExpression)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.GetConnection("StudentsPerformance")))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                adapter = new SqlDataAdapter(sqlCommand);

                dataSet = new DataSet();
                adapter.Fill(dataSet);
                resultReportDataGridView.DataSource = dataSet.Tables[0];
            }
        }
    }
}
