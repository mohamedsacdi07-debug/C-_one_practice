using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)

        {
            try
            {
              


                //creaing variable input and gettting values from texboxs

                string customername = txtcustomer.Text;
                double previousreading = double.Parse(txtprevious.Text);
                double currentreading = double.Parse(txtcurrent.Text);
                double priceperunit = double.Parse(txtunitprice.Text);

                //calculate electiricty usage

                double usageunits = currentreading - previousreading;

                // calculate bill
                double electricitycost = usageunits * priceperunit;
                double tax = electricitycost * (0.07);
                double fixedcharge = 5;
                //calculate total
                double totalbill = electricitycost + tax + fixedcharge;

                // display the result in labels

                lbloutputusage.Text = usageunits.ToString("");
                lbloutputtax.Text = "$" + tax.ToString("0.00");
                lbloutputTotal.Text = "$" + totalbill.ToString("0.00");

                 }
                    //handle invalid input catch

                    catch

                    {
                     MessageBox.Show ("please enter valid numeric values");
                    }







        }
    }
}
