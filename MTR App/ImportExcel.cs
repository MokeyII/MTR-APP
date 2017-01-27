using System;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
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
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "CREATE TABLE[dbo].[" + txtJobName.Text + "]([Item #] INT NOT NULL PRIMARY KEY IDENTITY,[Manufacturer] VARCHAR(55) NULL,[Mill Location] VARCHAR(55) NULL,[Product Description] VARCHAR(55) NULL,[Weld Seam Type] VARCHAR(55) NULL,[Outer Dimension] VARCHAR(55) NULL,[Wall Thickness] VARCHAR(55) NULL,[Coating] VARCHAR(55) NULL,[Grade] VARCHAR(55) NULL,[Heat] VARCHAR(55) NULL,[i] VARCHAR(55) NULL,[ANSI/ASME] VARCHAR(55) NULL,[Purchase Order] VARCHAR(55) NULL,[Standard] VARCHAR(55) NULL,[Notes] VARCHAR(55) NULL);";
                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();

                    con.Close();

                    Thread.Sleep(1000);

                    string excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtFileDir.Text + ";Extended Properties='Excel 12.0;IMEX=1;'";

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
                            // Bulk Copy to SQL Server
                            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(con))

                            {
                                con.Open();
                                bulkCopy.DestinationTableName = "" + txtJobName.Text + "";
                                bulkCopy.WriteToServer(dr);

                                MessageBox.Show("Data Exoprted To Sql Server Succefully");
                            }
                        }
                    }
                }

                try
                {
                    using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = ("INSERT INTO dbo.MasterTable ([Manufacturer], [Mill Location], [Product Description], [Weld Seam Type], [Outer Dimension], [Wall Thickness], [Coating], [Grade], [Heat], [ANSI/ASME], [Purchase Order], [Standard], [Notes]) SELECT [Manufacturer], [Mill Location], [Product Description], [Weld Seam Type], [Outer Dimension], [Wall Thickness], [Coating], [Grade], [Heat], [ANSI/ASME], [Purchase Order], [Standard], [Notes] FROM dbo." + txtJobName.Text + " ");

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = ("UPDATE dbo.MasterTable SET [Job Name] = (@JobName) WHERE [Job Name] IS NULL;");
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@Jobname", txtJobName.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            txtFileDir.Text = openFileDialog1.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}