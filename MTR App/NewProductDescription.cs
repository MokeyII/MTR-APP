using System;
using System.Data;
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

                    SqlParameter pProductDescription = new SqlParameter("@ProductDescription", SqlDbType.VarChar, 50);

                    pProductDescription.Value = txtCreateProductDescription.Text;

                    cmd.Parameters.Add(pProductDescription);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Product Description Added!");

                    this.Close();
                }
            }
            catch (SqlException ex)
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

                    SqlParameter pProductDescription = new SqlParameter("@ProductDescription", SqlDbType.VarChar, 50);

                    pProductDescription.Value = txtCreateProductDescription.Text;

                    cmd.Parameters.Add(pProductDescription);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Product Description Added!");

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

        private void NewProductDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Click Submit button
                btnSubmitProductDescription_Click(sender, e);
            }
        }
    }
}