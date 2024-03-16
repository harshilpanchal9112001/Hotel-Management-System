using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Assignment_3
{
    public partial class LoginPage : Form
    {
        OleDbConnection conn = new OleDbConnection();
        public LoginPage()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HARSHIL PANCHAL\Documents\Visual Studio 2008\Ass3_Database\LoginData.mdb";
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);            
        }
       

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";
                username.ForeColor = Color.Gray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.PasswordChar = '*';
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.PasswordChar = '\0';
                password.Text = "Password";
                password.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Login where Username = '"+ username.Text +"' and Password = '"+ password.Text +"'";            
            OleDbDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Username and password is correct.","Login Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Home h1 = new Home();
                this.Hide();
                h1.Show();
            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate username and password");
            }
            else
            {
                MessageBox.Show("Username and password is not Correct.","Login info",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}
