using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Assignment_3
{
    public partial class Check_out : UserControl
    {
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public Check_out()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HARSHIL PANCHAL\Documents\Visual Studio 2008\Ass3_Database\LoginData.mdb";
        }

        public void load_data()
        {
            try
            {
                CheckOutClass obj = new CheckOutClass();
                obj.open_connection();
                dataGridView1.DataSource = obj.view_data();
                obj.close_connection();
            }
            catch
            {
                MessageBox.Show("Error in read data", "ReadData Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Check_out_Load(object sender, EventArgs e)
        {
            load_data();
            //dataGridView1.CurrentRow.Selected = true;
        }

        private void Check_out_Paint(object sender, PaintEventArgs e)
        {
            load_data();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView1.CurrentRow.Selected = true;
                textbox_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                textbox_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                textbox_phone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                textBox_room.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                textBox_package.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                textBox_type.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                textbox_rate.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                textBox_checkin.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                textBox_checkout.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                textbox_days.Text = dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();

                int day = Convert.ToInt32(textbox_days.Text);
                int rate = Convert.ToInt32(textbox_rate.Text);

                try
                {
                    int package_price = 0;
                    conn.Open();
                    cmd.Connection = conn;
                    string qry = "select Package_price from package where Package_type = '" + textBox_package.Text + "'";
                    cmd.CommandText = qry;
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        package_price = Convert.ToInt32(reader["Package_price"]);
                    }
                    conn.Close();
                    reader.Close();

                    textBox_amount.Text = Convert.ToString((day * rate) + package_price);
                }
                catch
                {
                    MessageBox.Show("Can't Calculate Total Amount.", "Amount Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error in read data", "ReadData Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void check_Click(object sender, EventArgs e)
        {
            //try
            //{
                CheckOutClass obj1 = new CheckOutClass();
                obj1.open_connection();
                obj1.delete_checkout(Convert.ToInt32(textbox_id.Text));
                obj1.close_connection();
                MessageBox.Show("Check out successfully", "CheckOut Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bill b1 = new Bill();
                b1.Show();

                CheckOutClass c1 = new CheckOutClass();
                c1.open_connection();
                string s1 = "insert into Bill_data (Guest_ID,G_name,G_phone,Room_no,Package,Room_type,Room_rate,Check_In_Date,Check_Out_Date,No_Of_Days,Total_Amount) values (" + textbox_id.Text + ",'" + textbox_name.Text + "','" + textbox_phone.Text + "'," + textBox_room.Text + ",'" + textBox_package.Text + "','" + textBox_type.Text + "'," + textbox_rate.Text + ",'" + textBox_checkin.Text + "','" + textBox_checkout.Text + "','" + textbox_days.Text + "','" + textBox_amount.Text + "')";
                c1.insert_bill(s1);
                c1.close_connection();
                load_data();

                //Clear All TextBoxs
                textbox_id.Clear();
                textbox_name.Clear();
                textbox_phone.Clear();
                textBox_room.Clear();
                textBox_package.Clear();
                textBox_type.Clear();
                textbox_rate.Clear();
                textBox_checkin.Clear();
                textBox_checkout.Clear();
                textbox_days.Clear();
                textBox_amount.Clear();
            //}
            //catch
            //{
            //    MessageBox.Show("Error occueured while Check Out.", "CheckOut Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
