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
    class CheckInClass
    {
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        //OleDbDataReader reader;
        public void open_connection()
        {
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\HARSHIL PANCHAL\Documents\Visual Studio 2008\Ass3_Database\LoginData.mdb";
            conn.Open();
        }
        public void close_connection()
        {
            conn.Close();
        }
        
        public void insert_room(string qry)
        {
            cmd.Connection = conn;
            cmd.CommandText = qry;
            cmd.ExecuteNonQuery();
        }
        public void delete_room(int rno, string rtype, int rate,int person)
        {
            cmd.Connection = conn;
            cmd.CommandText = "delete RoomNo,RoomType,RoomRate,Person from Room where RoomNo=" + rno + " and RoomType='" + rtype + "' and RoomRate=" + rate + " and Person="+ person + "";
            cmd.ExecuteNonQuery();
        }
    }
}
