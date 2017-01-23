using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class NewStandard : Form
    {
        public NewStandard()
        {
            InitializeComponent();
        }

        private void btnSubmitStandard_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[Standard] ([Standard]) VALUES (@Standard)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@Standard", txtCreateStandard.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New Standard Added!");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewStandard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitStandard.PerformClick();
        }
    }
}