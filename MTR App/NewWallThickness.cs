using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class NewWallThickness : Form
    {
        public NewWallThickness()
        {
            InitializeComponent();
        }

        private void btnSubmitWallThickness_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[WallThickness] ([Wall Thickness]) VALUES (@WallThickness)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@WallThickness", txtCreateWallThickness.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New Wall Thickness Added!");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewWallThickness_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitWallThickness.PerformClick();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[WallThickness] ([Wall Thickness]) VALUES (@WallThickness)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@WallThickness", txtCreateWallThickness.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New Wall Thickness Added!");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}