using System;
using System.Data;
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

                    SqlParameter pStandard = new SqlParameter("@Standard", SqlDbType.VarChar, 50);

                    pStandard.Value = txtCreateStandard.Text;

                    cmd.Parameters.Add(pStandard);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Standard Added!");

                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewStandard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitStandard.PerformClick();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[Standard] ([Standard]) VALUES (@Standard)";
                    cmd.Connection = con;

                    SqlParameter pStandard = new SqlParameter("@Standard", SqlDbType.VarChar, 50);

                    pStandard.Value = txtCreateStandard.Text;

                    cmd.Parameters.Add(pStandard);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Standard Added!");

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

        private void txtCreateStandard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Click Submit button
                btnSubmitStandard_Click(sender, e);
            }
        }
    }
}