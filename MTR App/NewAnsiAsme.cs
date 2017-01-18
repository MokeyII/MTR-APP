using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
    }
}
