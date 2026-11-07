using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lab_Assigment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            {  //creating vribale
                double calories, fatGrams;

                if (double.TryParse(txtclories.Text, out calories) &&
                    double.TryParse(txtfatgram.Text, out fatGrams) &&
                    calories > 0 && fatGrams >= 0)
                {
                    double caloriesFromFat = fatGrams * 9;
                    if (caloriesFromFat > calories)
                    {
                        MessageBox.Show("Fat calories cannot be greater than total calories.");
                        checkBoxlowfat.Checked = false;
                        //return;
                    }
                    //calculate percentage
                    double percentage = (caloriesFromFat / calories) * 100;

                    lblnumber.Text = "Calories from Fat: " + caloriesFromFat;
                    label3.Text = "Percentage of Fat: " + percentage.ToString("F2") + "%";


                    if (percentage < 30)
                    {
                        lblpercentage.Text += "\nThis food is low in fat.";
                        checkBoxlowfat.Checked = true;
                    }
                    else
                    {
                        lblpercentage.Text += "\nThis food is not low in fat.";
                        checkBoxlowfat.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid numbers.");
                }
            }
        }
    }
}
