﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MTR_App
{
    public partial class NewMillLocation : Form
    {
        public NewMillLocation()
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
                    cmd.CommandText = "INSERT INTO dbo.[MillLocation] ([Mill Location]) VALUES (@MillLocation)";
                    cmd.Connection = con;

                    SqlParameter pMillLocation = new SqlParameter("@MillLocation", SqlDbType.VarChar, 50);

                    pMillLocation.Value = txtCreateMillLocation.Text;

                    cmd.Parameters.Add(pMillLocation);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Mill Location Added!");

                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCreateMillLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSubmitJobName.PerformClick();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.MTRInfoTablesConn))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO dbo.[MillLocation] ([Mill Location]) VALUES (@MillLocation)";
                    cmd.Connection = con;

                    SqlParameter pMillLocation = new SqlParameter("@MillLocation", SqlDbType.VarChar, 50);

                    pMillLocation.Value = txtCreateMillLocation.Text;

                    cmd.Parameters.Add(pMillLocation);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("New Mill Location Added!");

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

        private void NewMillLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //Click Submit button
                btnSubmitJobName_Click(sender, e);
            }
        }
    }
}