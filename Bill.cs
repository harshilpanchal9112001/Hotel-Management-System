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
    public partial class Bill : Form
    {
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public Bill()
        {
            InitializeComponent();
        }

        public void open_connection()
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HARSHIL PANCHAL\Documents\Visual Studio 2008\Ass3_Database\LoginData.mdb";
            conn.Open();
        }
        public void close_connection()
        {
            conn.Close();
        }
        

        private void Bill_Load(object sender, EventArgs e)
        {
            //try
            //{
                double total_amt = 0,sgst = 0,cgst = 0,gr_total = 0;
                string pack = "";
                open_connection();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Bill_data";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label_G_id.Text = (reader["Guest_ID"].ToString());
                    label_name.Text = (reader["G_name"].ToString());
                    label_Phone_number.Text = (reader["G_phone"].ToString());
                    label_R_number.Text = (reader["Room_no"].ToString());
                    pack = (reader["Package"].ToString());
                    label_type.Text = (reader["Room_type"].ToString());
                    label_rate.Text = (reader["Room_rate"].ToString());
                    label_checkin.Text = (reader["Check_In_Date"].ToString());
                    label_Checkout.Text = (reader["Check_Out_Date"].ToString());
                    label_days.Text = (reader["No_Of_Days"].ToString());
                    total_amt = Convert.ToInt32((reader["Total_Amount"]));
                }

                label_Total_amount.Text = Convert.ToString(total_amt);
                sgst = total_amt * 0.09;
                cgst = total_amt * 0.09;
                gr_total = total_amt + sgst + cgst;
                label_Sgst.Text = Convert.ToString(sgst);
                label_Cgst.Text = Convert.ToString(cgst);
                label_Grand_Total.Text = Convert.ToString(gr_total);

                close_connection();
                reader.Close();

                
                int package_price = 0;
                open_connection();
                cmd.Connection = conn;
                string qry = "select Package_price from package where '"+ label_package.Text +"'";
                cmd.CommandText = qry;
                OleDbDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    package_price = Convert.ToInt32(reader1["Package_price"]);
                }
                label_package.Text = pack + " (Rs. " + package_price + ")";
                close_connection();
                reader1.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Error while Generating Invoice.", "Invoice Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home obj = new Home();
            obj.Show();
        }
    }
}
