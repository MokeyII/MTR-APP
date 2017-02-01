﻿using System;
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
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[AnsiAsme]([ANSI / ASME]) VALUES(@AnsiAsme)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@AnsiAsme", txtCreateAnsiAsme.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New ANSI / ASME Added!");

                    this.Close();
                }
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[AnsiAsme]([ANSI / ASME]) VALUES(@AnsiAsme)";
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@AnsiAsme", txtCreateAnsiAsme.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New ANSI / ASME Added!");

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

        private void txtCreateAnsiAsme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Click Submit button
                btnSubmitAnsiAsme_Click(sender, e);
            }
        }
    }
}