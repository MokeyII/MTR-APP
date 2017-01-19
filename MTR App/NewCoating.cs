using System;
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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[Coating] ([Coating]) VALUES (@Coating) ", con);
                cmd.Parameters.AddWithValue("@Coating", txtCreateCoating.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Coating Added!");
                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}