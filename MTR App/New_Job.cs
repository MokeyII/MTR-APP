using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class New_Job : Form
    {
        public New_Job()
        {
            InitializeComponent();
        }

        private void btnSubmitJobName_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "CREATE TABLE[dbo].[" + txtCreateJobName.Text + "]([Item #] INT NOT NULL PRIMARY KEY IDENTITY,[Manufacturer] VARCHAR(55) NULL,[Mill Location] VARCHAR(55) NULL,[Product Description] VARCHAR(55) NULL,[Weld Seam Type] VARCHAR(55) NULL,[Outer Dimension] VARCHAR(55) NULL,[Wall Thickness] VARCHAR(55) NULL,[Coating] VARCHAR(55) NULL,[Grade] VARCHAR(55) NULL,[Heat] VARCHAR(55) NULL,[i] VARCHAR(55) NULL,[ANSI/ASME] VARCHAR(55) NULL,[Purchase Order] VARCHAR(55) NULL,[Standard] VARCHAR(55) NULL,[Notes] VARCHAR(55) NULL);";
                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New Job Created");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCreateJobName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitJobName.PerformClick();
        }
    }
}