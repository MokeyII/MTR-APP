using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.IO;

namespace MTR_App
{
    public partial class New_Job : Form
    {
        public New_Job()
        {
            InitializeComponent();
        }

        private void btnSubmitJob_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRDataBaseConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "CREATE TABLE[dbo].[" + txtCreateJobName.Text + "]([Item #] INT NOT NULL PRIMARY KEY IDENTITY,[Manufacturer] VARCHAR(55) NULL,[Mill Location] VARCHAR(55) NULL,[Product Description] VARCHAR(55) NULL,[Weld Seam Type] VARCHAR(55) NULL,[Outer Dimension] VARCHAR(55) NULL,[Wall Thickness] VARCHAR(55) NULL,[Coating] VARCHAR(55) NULL,[Grade] VARCHAR(55) NULL,[Heat] VARCHAR(55) NULL,[i] VARCHAR(55) NULL,[ANSI/ASME] VARCHAR(55) NULL,[Purchase Order] VARCHAR(55) NULL,[Standard] VARCHAR(55) NULL,[Notes] VARCHAR(55) NULL, [Unique Identifier] VARCHAR(55) NOT NULL);";
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCreateJobName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Click Submit button
                btnSubmitJob_Click(sender, e);
            }
        }
    }
}