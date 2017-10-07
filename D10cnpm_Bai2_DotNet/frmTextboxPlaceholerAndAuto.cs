using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;


namespace D10cnpm_Bai2_DotNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Ninh xinh gái")
            {
                txtName.Text = ""; txtName.ForeColor = Color.Black;
            }

        }

        private void txtName_Leave(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                txtName.Text = "Ninh xinh gái"; txtName.ForeColor = Color.DarkGray;
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void txtText_Enter(object sender, EventArgs e)
        {
            if (txtText.Text == "Enter your text")
            {
                txtText.Text = ""; txtText.ForeColor = Color.Black;
            }
        }

        private void txtText_Leave(object sender, EventArgs e)
        {
            if (txtText.Text == "")
            {
                txtText.Text = "Enter your text"; txtText.ForeColor = Color.DarkGray;
            }
        }

        int i = 10;
        private void timer_Tick(object sender, EventArgs e)
        {
            lbShow.Left += i;
            if(lbShow.Left>700)
            {
                i -= 10;
            }
            if(lbShow.Left<12)
            {
                i += 10;
            }
        }



       
    }
}
