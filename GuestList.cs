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
    public partial class GuestList : UserControl
    {
        public GuestList()
        {
            InitializeComponent();
        }
        public void load_data()
        {
            GuestListClass obj = new GuestListClass();
            obj.open_connection();
            dataGridView1.DataSource = obj.view_data();
            obj.close_connection();
        }
        private void GuestList_Load(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.Enabled = false;
                load_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void GuestList_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void GuestList_Paint_2(object sender, PaintEventArgs e)
        {
            load_data();
        }
    }
}
