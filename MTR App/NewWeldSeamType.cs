using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class NewWeldSeamType : Form
    {
        public NewWeldSeamType()
        {
            InitializeComponent();
        }

        private void btnSubmitWeldSeamType_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[WeldSeamType] ([Weld Seam Type]) VALUES (@WeldSeamType)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@WeldSeamType", txtCreateWeldSeamType.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New Weld Seam Type Added!");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCreateWeldSeamType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitWeldSeamType.PerformClick();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[WeldSeamType] ([Weld Seam Type]) VALUES (@WeldSeamType)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@WeldSeamType", txtCreateWeldSeamType.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New Weld Seam Type Added!");

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

        private void NewWeldSeamType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Click Submit button
                btnSubmitWeldSeamType_Click(sender, e);
            }
        }
    }
}