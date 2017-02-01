using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class NewGrade : Form
    {
        public NewGrade()
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
                    cmd.CommandText = "INSERT INTO dbo.[Grade] ([Grade]) VALUES (@Grade)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@Grade", txtCreateGradeName.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New Grade Added!");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCreateGradeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnCreateGrade.PerformClick();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[Grade] ([Grade]) VALUES (@Grade)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@Grade", txtCreateGradeName.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New Grade Added!");

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

        private void NewGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Click Submit button
                btnSubmitJobName_Click(sender, e);
            }
        }
    }
}