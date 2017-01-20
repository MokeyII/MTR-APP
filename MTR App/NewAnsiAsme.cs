using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class NewAnsiAsme : Form
    {
        public NewAnsiAsme()
        {
            InitializeComponent();
        }

        private void btnSubmitAnsiAsme_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MTRInfoTables;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.[AnsiAsme] ([ANSI/ASME]) VALUES (@AnsiAsme) ", con);
                cmd.Parameters.AddWithValue("@AnsiAsme", txtCreateAnsiAsme.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New ANSI / ASME Added!");
                con.Close();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCreateAnsiAsme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitAnsiAsme.PerformClick();
        }
    }
}