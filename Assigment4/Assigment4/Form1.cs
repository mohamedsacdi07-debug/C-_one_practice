using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment4
{

    
        public partial class Form1 : Form
        {
            string filePath = "students.txt";

            public Form1()
            {
                InitializeComponent();

                radioundergraduate.Checked = true;
            }

            private void btnsave_Click(object sender, EventArgs e)
        {
            //create varibale 
            int studentid;
            string studentname, department;
            double MARK;

            {
                if (txtstudentid.Text == "" ||
                    txtstudentname.Text == "" ||
                    txtdepertment.Text == "" ||
                    txtmark.Text == "")
                {
                    MessageBox.Show("Please fill all fields!");
                    return;
                }

                if (!double.TryParse(txtmark.Text, out double mark) || mark < 0)
                {
                    MessageBox.Show("Mark must be a non-negative number!");
                    return;
                }

                string studentType = radioundergraduate.Checked ? "Undergraduate": "Postgraduate";

                string studentInfo =
                    "Student ID: " + txtstudentid.Text +
                    "\r\nStudent Name: " + txtstudentname.Text +
                    "\r\nDepartment: " + txtdepertment.Text +
                    "\r\nMark: " + mark +
                    "\r\nStudent Type: " + studentType +
                    "\r\n----------------------------\r\n";

             File.AppendAllText(filePath, studentInfo);

                MessageBox.Show("Student information saved successfully!");

                ClearFields();
            }



        }

        private void btnread_Click(object sender, EventArgs e)

        {
            StreamReader moha;
            {
                if (File.Exists(filePath))
                {
                    string data = File.ReadAllText(filePath);

                    btnsave.Text = data;
                }
                else
                {
                    MessageBox.Show("File does not exist!");

                    
                }
                
            }


            




        }
        

        private void btnclear_Click(object sender, EventArgs e)
        {
           
            
  
        }

        // CLEAR FUNCTION
        private void ClearFields()
        {
            txtstudentid.Clear();
            txtstudentname.Clear();
            txtdepertment.Clear();
            txtmark.Clear();

            radioundergraduate.Checked = true;
            txtstudentid.Focus();
        }

     

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            //eix 

            this.Close();
        }
    }
    }

