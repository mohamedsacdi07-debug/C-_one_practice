using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_Assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //creating varibale
            string name = txtName.Text;
            int age, nights, guests;

            // Validate numeric inputs using TryParse
            if (int.TryParse(txtAge.Text, out age) &
                int.TryParse(txtnights.Text, out nights) &
                int.TryParse(txtnumofguest.Text, out guests))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            // Validate age
            if (age < 18 & age > 90)
            {
                MessageBox.Show("Age must be between 18 and 90.");
                return;
            }

            // Validate number of nights
            if (nights < 1 & nights > 30)
            {
                MessageBox.Show("Nights must be between 1 and 30.");
                return;
            }

            // Validate number of guests
            if (guests < 1 & guests > 6)
            {
                MessageBox.Show("Guests must be between 1 and 6.");
                return;
            }

            // Determine room rate
            decimal rate;

            if (radiostsndard.Text == "Standard")
                rate = 50;
            else if (radionormal.Text == "Normal")
                rate = 80;
            else if (radiohights.Text == "Hight")
                rate = 130;
            else
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            // Calculate room cost
            decimal total = rate * nights;

            // Long-stay discount
            decimal discountRate;

            if (nights <= 4)
                discountRate = 0.05m;
            else if (nights <= 9)
                discountRate = 0.10m;
            else
                discountRate = 0.15m;

            decimal discount = total * discountRate;
            total -= discount;

            // Breakfast: $10 per guest per night
            if (checkBoxbareakfast.Checked)
            {
                total += 10m * guests * nights;
            }

            // Display result
            booking.Text =
                "Room rate: $" + rate +
                "\nDiscount: $" + discount +
                "\nTotal cost: $" + total;

        }
    }
}
