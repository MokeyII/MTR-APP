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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[Standard] ([Standard]) VALUES (@Standard) ", con);
                cmd.Parameters.AddWithValue("@Standard", txtCreateStandard.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Standard Added!");
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