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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTR_Database;Integrated Security=True");

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("CREATE TABLE [dbo].[" + txtCreateJobName.Text + "]([Item #] INT NOT NULL PRIMARY KEY IDENTITY,[Manufacturer] NCHAR(55) NULL,[Mill Location] NCHAR(55) NULL,[Product Description] NCHAR(55) NULL,[Weld Seam Type] NCHAR(55) NULL,[Outer Dimension] NCHAR(55) NULL,[Wall Thickness] NCHAR(55) NULL,[Coating] NCHAR(55) NULL,[Grade] NCHAR(55) NULL,[Heat] NCHAR(55) NULL,[i] NCHAR(1) NULL,[ANSI/ASME] NCHAR(55) NULL,[Purchase Order] NCHAR(55) NULL,[Standard] NCHAR(55) NULL,[Notes] NCHAR(55) NULL);", con))
                    cmd.ExecuteNonQuery();
                MessageBox.Show("New Job Created");
                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}