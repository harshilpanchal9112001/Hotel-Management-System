using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape1.Width += 5;
                if (rectangleShape1.Width >= 420)
                {
                    timer1.Stop();
                    LoginPage obj = new LoginPage();
                    obj.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Error While Loading page.");
            }
        }

        
    }
}
