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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[ProductDescription] ([Product Description]) VALUES (@ProductDescription) ", con);
                cmd.Parameters.AddWithValue("@ProductDescription", txtCreateProductDescription.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Product Description Added!");
                con.Close();
                this.Close();
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
    }
}