﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Inventory_Management_System_017
{
    public partial class login_pg : Form
    {
        String userName;
        public login_pg()
        {
            InitializeComponent();
        }

        private void newRegistration_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NewRegistration nr = new NewRegistration();
            nr.Closed += (s, args) => this.Hide();
            nr.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryProject00;Integrated Security=True");
            String qr = "select UserName,Pass,RoleID from tblUser where UserName=@UserName AND Pass=@Pass";
            conn.Open();
            SqlCommand cmd = new SqlCommand(qr, conn);
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Pass", txtPassword.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            if (dt.Rows.Count >= 1)
            {
                userName = txtUserName.Text;
                this.Hide();
                Dashboard d = new Dashboard();
                d.Closed += (s, args) => this.Hide();
                d.Show();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void login_pg_Load(object sender, EventArgs e)
        {
            // for efficient access to other forms
            txtPassword.UseSystemPasswordChar = true;
            txtUserName.Text = "admin";
            txtPassword.Text = "admin";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
                
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
                
        }
    }
}
