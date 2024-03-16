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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                LoginPage l1 = new LoginPage();
                l1.Show();
                this.Hide();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                LoginPage l1 = new LoginPage();
                l1.Show();
                this.Hide();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void check_Click(object sender, EventArgs e)
        {
            try
            {
                check_in2.Show();
                room2.Hide();
                guestList1.Hide();
                check_out1.Hide();
                check_in2.BringToFront();
            }
            catch
            {
                MessageBox.Show("Some Error Occuered");
            }
        }

        private void body_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Home_Load_1(object sender, EventArgs e)
        {
            try
            {
                check_in2.Hide();
                room2.Hide();
                guestList1.Hide();
                check_out1.Hide();
            }
            catch
            {
                MessageBox.Show("Some Error Occuered");
            }
        }

        private void room_Click(object sender, EventArgs e)
        {
            try
            {
                room2.Show();
                check_in2.Hide();
                guestList1.Hide();
                check_out1.Hide();
                room2.BringToFront();
            }
            catch
            {
                MessageBox.Show("Some Error Occuered");
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guest_Click(object sender, EventArgs e)
        {
            try
            {
                guestList1.Show();
                room2.Hide();
                check_in2.Hide();
                check_out1.Hide();
                guestList1.BringToFront();
            }
            catch
            {
                MessageBox.Show("Some Error Occuered");
            }
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            try
            {
                check_out1.Show();
                guestList1.Hide();
                room2.Hide();
                check_in2.Hide();
                check_out1.BringToFront();
            }
            catch
            {
                MessageBox.Show("Some Error Occuered");
            }
        }
    }
}
