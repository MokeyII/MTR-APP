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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[Grade] ([Grade]) VALUES (@Grade) ", con);
                cmd.Parameters.AddWithValue("@Grade", txtCreateGradeName.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Grade Added!");
                con.Close();
                this.Close();
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
    }
}