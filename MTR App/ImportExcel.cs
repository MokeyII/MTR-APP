using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class ImportExcel : Form
    {
        public ImportExcel()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // Connection String to Excel Workbook,Replace DataSource value to point to your excel file location
            string excelConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtFileDir.Text + " ;Extended Properties=Excel 8.0";


            // Create Connection to Excel Workbook
            using (OleDbConnection connection =
                         new OleDbConnection(excelConnectionString))
            {
                OleDbCommand command = new OleDbCommand
                        ("Select * FROM [Sheet1$]", connection);

                connection.Open();

                // Create DbDataReader to Data Worksheet
                using (DbDataReader dr = command.ExecuteReader())
                {
                    // SQL Server Connection String
                    string sqlConnectionString = "Data Source=YourSource;Initial Catalog=YourDataBase;Integrated Security=True";

                    // Bulk Copy to SQL Server
                    using (SqlBulkCopy bulkCopy =
                               new SqlBulkCopy(sqlConnectionString))
                    {
                        bulkCopy.DestinationTableName = "YourTableName";
                        bulkCopy.WriteToServer(dr);
                        MessageBox.Show("Data Exoprted To Sql Server Succefully");
                    }
                }
            }
    }
}
