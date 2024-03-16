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
    public partial class Room : UserControl
    {
        OleDbConnection conn = new OleDbConnection();
        public Room()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HARSHIL PANCHAL\Documents\Visual Studio 2008\Ass3_Database\LoginData.mdb";
        }
        public void load_data()
        {
            try
            {
                RoomClass con_obj = new RoomClass();
                con_obj.open_connection();
                dataGridView1.DataSource = con_obj.view_data();
                con_obj.close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void Room_Load(object sender, EventArgs e)
        {
            try
            {
                room_type.SelectedIndex = 0;
                RoomClass con_obj = new RoomClass();
                con_obj.open_connection();
                DataTable dt = new DataTable();
                dt = con_obj.view_data();
                dataGridView1.DataSource = dt;
                con_obj.close_connection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (room_no.Text != "" && room_rate.Text != "" && room_type.Text != "" && person.Text != "")
                {
                    RoomClass con_obj = new RoomClass();
                    con_obj.open_connection();
                    string str = "insert into Room (RoomNo,RoomType,RoomRate,Person) values (' " + room_no.Text + "','" + room_type.Text + "','" + room_rate.Text + "','" + person.Text + "')";
                    con_obj.insert_data(str);
                    con_obj.close_connection();
                    load_data();
                    MessageBox.Show("Room Data Successfully Inserted.", "Room Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Fill all details.", "Room Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch 
            {
                MessageBox.Show("The given Room Number is already ExistS.","Room Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (room_rate.Text != "" && room_type.Text != "" && person.Text != "")
                {
                    RoomClass con_obj = new RoomClass();
                    con_obj.open_connection();
                    string r_type = room_type.SelectedItem.ToString();
                    con_obj.update_data(r_type, Convert.ToInt32(room_no.Text), Convert.ToInt32(room_rate.Text), Convert.ToInt32(person.Text));
                    con_obj.close_connection();
                    load_data();
                    MessageBox.Show("Room Data Successfully Updated.", "Room Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Make sure all details are Filled", "Room Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
                room_no.Enabled = false;
                room_no.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                room_type.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                room_rate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                person.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (room_no.Text != "")
                {
                    RoomClass con_obj = new RoomClass();
                    con_obj.open_connection();
                    con_obj.delete_data(Convert.ToInt32(room_no.Text));
                    con_obj.close_connection();
                    load_data();
                    MessageBox.Show("Room Data Deleted.", "Room Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Select Room Number.", "Room Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                save.Enabled = false;
                update.Visible = true;
                delete.Visible = true;
                dataGridView1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Something went wrong.", "Room Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear
                room_no.Clear();
                room_rate.Clear();
                person.Clear();
                room_type.SelectedIndex = 0;

                // Button permissions :
                room_no.Enabled = true;
                save.Enabled = true;
                update.Visible = false;
                delete.Visible = false;

                RoomClass con_obj = new RoomClass();
                con_obj.open_connection();
                DataTable dt = new DataTable();
                dt = con_obj.view_data();
                dataGridView1.DataSource = dt;
                con_obj.close_connection();
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                int cnt = 0;
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select RoomNo from Room where RoomNo = " + room_no.Text + "";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cnt += 1;
                }
                if (cnt == 1)
                {
                    MessageBox.Show("The Given Room Number is Found.", "Room Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The Given Room Number is not Found.", "Room Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("For Searching the Room Availability enter only Room Number.", "Room Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
