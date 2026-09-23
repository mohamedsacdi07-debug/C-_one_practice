using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            //creating varibale
            string studentname,depertment, semester, fulloff;
            int studentid;

            studentname = txtname.Text;
            studentid = int.Parse(txtstudentid.Text);
            depertment = txtdepertment.Text;
            semester = txtsemester.Text;

            //concatination

            fulloff = studentname + "," + studentid + "," + depertment + "," + semester;

            //display the output
            lbloutput.Text = fulloff;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear texbox & label
            txtname.Clear();
            txtstudentid.Clear();
            txtdepertment.Clear();
            txtsemester.Clear();
            lbloutput.Text = string.Empty;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
