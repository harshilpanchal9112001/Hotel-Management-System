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
    class RoomClass
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
        public DataTable view_data()
        {
            DataTable data_table = new DataTable();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Room";
            cmd.ExecuteNonQuery();
            OleDbDataAdapter data_adpt = new OleDbDataAdapter(cmd);
            data_adpt.Fill(data_table);
            return data_table;
        }
        public void insert_data(string qry)
        {
            cmd.Connection = conn;
            cmd.CommandText = qry;
            cmd.ExecuteNonQuery();
        }
        public void update_data(string type, int number, int rate, int person)
        {
            cmd.Connection = conn;
            cmd.CommandText = "update Room set RoomType='" + type + "', RoomRate = " + rate + ", Person=" + person + " where RoomNo = " + number + "";
            cmd.ExecuteNonQuery();
        }
        public void delete_data(int room_no)
        {
            cmd.Connection = conn;
            cmd.CommandText = "delete from Room where RoomNo = " + room_no + " ";
            cmd.ExecuteNonQuery();
        }
    }
}
