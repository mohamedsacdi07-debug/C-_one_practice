using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace open_file_dialog_save_dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //import class
            StreamReader reads;

            //open dialog 
            DialogResult result;

            //daynmic file path
            result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //open file
                reads = File.OpenText(openFileDialog1.FileName);
                while (reads.EndOfStream == false)
                {
                    string lines;
                    lines = reads.ReadLine();
                    listBox1.Items.Add(lines);

                }
                reads.Close();


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writes;

            DialogResult results;

            results = SaveFileDialog1.ShowDialog();

            if(results == DialogResult.OK)
            {
                writes = File.CreateText(SaveFileDialog1.FileName);

                writes.WriteLine("mohamed");
                writes.Close();
            }
            else if (results == DialogResult.Cancel)
            {

            }
                
        }
    }
}
