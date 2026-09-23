using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)

        {
            //close the form usign close fucntion
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating vribale
            string dayofweek, month, day, year, fulldate;

            //assign varible to  user input
            dayofweek = txtenterdayofweek.Text;
            month = txtnameofmonth.Text;
            day = txtnumericofthemonth.Text;
            year = txtyear.Text;

            //process usign concatiantion
            fulldate = dayofweek + "," + month + "," + day + "," + year;

            //display the output
            lblconcatination.Text = fulldate;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear texbox and label
            txtenterdayofweek.Text = "";
            txtnameofmonth.Clear();
            txtnumericofthemonth.Clear();
            txtyear.Clear();
            lblconcatination.Text = string.Empty;
        }
    }
}
