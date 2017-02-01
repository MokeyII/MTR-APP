using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class NewProductDescription : Form
    {
        public NewProductDescription()
        {
            InitializeComponent();
        }

        private void btnSubmitProductDescription_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[ProductDescription] ([Product Description]) VALUES (@ProductDescription)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@ProductDescription", txtCreateProductDescription.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New Product Description Added!");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCreateProductDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitProductDescription.PerformClick();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[ProductDescription] ([Product Description]) VALUES (@ProductDescription)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@ProductDescription", txtCreateProductDescription.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New Product Description Added!");

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