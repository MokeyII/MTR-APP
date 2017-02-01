using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class NewMillLocation : Form
    {
        public NewMillLocation()
        {
            InitializeComponent();
        }

        private void btnSubmitJobName_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[MillLocation] ([Mill Location]) VALUES (@MillLocation)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@MillLocation", txtCreateMillLocation.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New Mill Location Added!");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCreateMillLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitJobName.PerformClick();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[MillLocation] ([Mill Location]) VALUES (@MillLocation)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@MillLocation", txtCreateMillLocation.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New Mill Location Added!");

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
    }
}