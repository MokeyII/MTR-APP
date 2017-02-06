using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class NewCoating : Form
    {
        public NewCoating()
        {
            InitializeComponent();
        }

        private void btnSubmitCoating_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[Coating] ([Coating]) VALUES (@Coating)";
                    cmd.Connection = con;

                    SqlParameter pCoating = new SqlParameter("@Coating", SqlDbType.VarChar, 50);

                    pCoating.Value = txtCreateCoating.Text;

                    cmd.Parameters.Add(pCoating);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Coating Added!");

                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewCoating_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitCoating.PerformClick();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[Coating] ([Coating]) VALUES (@Coating)";
                    cmd.Connection = con;

                    SqlParameter pCoating = new SqlParameter("@Coating", SqlDbType.VarChar, 50);

                    pCoating.Value = txtCreateCoating.Text;

                    cmd.Parameters.Add(pCoating);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Coating Added!");

                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCreateCoating_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Click Submit button
                btnSubmitCoating_Click(sender, e);
            }
        }
    }
}