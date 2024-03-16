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
    class CheckOutClass
    {
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        public void open_connection()
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HARSHIL PANCHAL\Documents\Visual Studio 2008\Ass3_Database\LoginData.mdb";
            conn.Open();
        }
        public void close_connection()
        {
            conn.Close();
        }

        public void insert_bill(string qry) // Insert details to generate Bill
        {
            cmd.Connection = conn;
            cmd.CommandText = qry;
            cmd.ExecuteNonQuery();
        }

        public void delete_checkout(int id) // delete the check out details
        {
            cmd.Connection = conn;
            cmd.CommandText = "delete from Checkin where G_ID = " + id + "";
            cmd.ExecuteNonQuery();
        }

        public DataTable view_data() // For updating the Check Out List
        {
            DataTable data_table = new DataTable();
            cmd.Connection = conn;
            cmd.CommandText = "select G_ID,G_name,G_phone,Room_no,Package,Room_type,Room_rate,Check_In_Date,Check_Out_Date,No_Of_Days from Checkin";
            cmd.ExecuteNonQuery();
            OleDbDataAdapter data_adpt = new OleDbDataAdapter(cmd);
            data_adpt.Fill(data_table);
            return data_table;
        }
    }
}
