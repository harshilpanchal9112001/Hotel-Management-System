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
    public partial class check_in : UserControl
    {
        OleDbConnection conn = new OleDbConnection();
        OleDbConnection conn2 = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public check_in()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HARSHIL PANCHAL\Documents\Visual Studio 2008\Ass3_Database\LoginData.mdb";
        }

        private void back_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                id.Clear();
                name.Clear();
                phone_number.Clear();
                combobox_room_no.Text = "";
                cmb_room_type.Clear();
                room_rate.Clear();
                person.Clear();
                number_of_days.Clear();
                cmb_package.Text = ""; 
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void check_in_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HARSHIL PANCHAL\Documents\Visual Studio 2008\Ass3_Database\LoginData.mdb";
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Room";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combobox_room_no.Items.Add(reader["RoomNo"].ToString());
                }
                conn.Close();
                reader.Close();

                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Package";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmb_package.Items.Add(reader["Package_type"].ToString());
                }
                conn.Close();
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Can't Update Room Number Details.", "Room Number Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            }
            catch
            {
                MessageBox.Show("Error Load Page","Page Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combobox_room_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                int item = Convert.ToInt32(combobox_room_no.Text);
                string qry = "select * from Room where RoomNo = " + item + "";
                cmd.CommandText = qry;
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmb_room_type.Text = (reader["RoomType"].ToString());
                    room_rate.Text = (reader["RoomRate"]).ToString();
                    person.Text = (reader["Person"].ToString());
                }
                conn.Close();
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Some Error Occuered, Please Restart your System.");
            }
        }

        private void check_out_date_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_package.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Choose your Package","Package Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    DateTime D_in = check_in_date.Value.Date;
                    DateTime D_out = check_out_date.Value.Date;

                    TimeSpan ts = D_out - D_in;
                    int days = ts.Days;
                    if (days <= 0)
                    {
                        MessageBox.Show("Please Choose appropriate date.","Date Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        number_of_days.Text = Convert.ToString(days);
                    }                
                }
            }
            catch
            {
                MessageBox.Show("Please Choose Check out date.", "Date Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combobox_room_no_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        
        private void check_Click(object sender, EventArgs e)
        {
            int cnt2 = combobox_room_no.SelectedIndex;
            int cnt3 = cmb_package.SelectedIndex;
            string cnt4 = Convert.ToString(cmb_room_type.Text);
            int cnt5 = Convert.ToInt32(room_rate.Text);
            if (id.Text == "" || name.Text == "" || phone_number.Text == "" || number_of_days.Text == "" || room_rate.Text == "" || cnt2 == -1 || cnt3 == -1 || cnt4 == "")
            {
                MessageBox.Show("Please Fill all the details.","Check Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    CheckInClass obj = new CheckInClass();
                    obj.open_connection();
                    string str = "insert into Checkin (G_ID,G_name,G_phone,Room_no,Package,Room_type,Room_rate,Check_In_Date,Check_Out_Date,No_Of_Days) values (" + Convert.ToInt32(id.Text) + ",'" + name.Text + "','" + phone_number.Text + "'," + Convert.ToInt32(combobox_room_no.SelectedItem.ToString()) + ",'" + cmb_package.SelectedItem.ToString() + "','" + cmb_room_type.Text + "'," + Convert.ToInt32(room_rate.Text) + ",'" + check_in_date.Text + "','" + check_out_date.Text + "'," + Convert.ToInt32(number_of_days.Text) + ")";
                    obj.insert_room(str);
                    obj.delete_room(Convert.ToInt32(combobox_room_no.SelectedItem.ToString()), Convert.ToString(cmb_room_type.Text), Convert.ToInt32(room_rate.Text), Convert.ToInt32(person.Text));
                    MessageBox.Show("Welcome to the Sunset Desert Hotel \n        Your Room Number is " + combobox_room_no.Text + "","CheckIn Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    obj.close_connection();
                }
                catch
                {
                    MessageBox.Show("Please Enter Unique Guest ID.", "Check Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void phone_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                char ch = e.KeyChar;
                if (!Char.IsDigit(ch) && ch != 8)
                {
                    e.Handled = true;
                }
            }
            catch
            {
                MessageBox.Show("Phone Number must contain Numeric values.","Phone Number Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                char ch = e.KeyChar;
                if (!Char.IsDigit(ch) && ch != 8)
                {
                    e.Handled = true;
                }
            }
            catch
            {
                MessageBox.Show("Guest ID Must in Numeric value.");
            }
        }

        private void check_in_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                id.Clear();
                name.Clear();
                phone_number.Clear();
                combobox_room_no.Text = "";
                cmb_room_type.Clear();
                room_rate.Clear();
                person.Clear();
                number_of_days.Clear();
                cmb_package.Text = "";

                combobox_room_no.Items.Clear();
                OleDbConnection conn = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();
                conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HARSHIL PANCHAL\Documents\Visual Studio 2008\Ass3_Database\LoginData.mdb";
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Room";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    combobox_room_no.Items.Add(reader["RoomNo"].ToString());
                }
                conn.Close();
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Can't Update Room Number Details.", "Room Number Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
    }
}
