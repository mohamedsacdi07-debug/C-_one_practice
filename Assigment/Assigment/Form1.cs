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

namespace Assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // File location: Documents folder
        string filePath = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments),
            "AssignmentFile.txt");

        // Display file items in ListBox
        private void LoadItems()
        {
            listBox1.Items.Clear();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }
        }

      

        private void btnreadfunctions_Click(object sender, EventArgs e)


        {
              // Create file and add sample items
        
        {
            if (!File.Exists(filePath))
            {
                string[] items =
                {
                    "mohamed",
                    "sacdi",
                    "jamhuriya",
                    "java"
                };

                File.WriteAllLines(filePath, items);
            }
        }


            if (!File.Exists(filePath))

            {

                MessageBox.Show("File does not exist!");

                return;

            }

            string result = "";

            // Peek()

            using (StreamReader reader = new StreamReader(filePath))

            {

                int character = reader.Peek();

                result += "PEEK(): ";

                if (character != -1)

                    result += (char)character + "\n\n";

                else

                    result += "File is empty.\n\n";

            }

            // ReadBlock()

            using (StreamReader reader = new StreamReader(filePath))

            {

                char[] data = new char[20];

                int count = reader.ReadBlock(data, 0, 20);

                result += "READBLOCK():\n";

                result += new string(data, 0, count) + "\n\n";

            }

            //  Read(char[])

            using (StreamReader reader = new StreamReader(filePath))

            {

                char[] data = new char[20];

                int count = reader.Read(data, 0, 20);

                result += "READ(char[]):\n";

                result += new string(data, 0, count);

            }

            // Show reading results

            MessageBox.Show(result, "Reading Functions");

            // Display file items in ListBox
            LoadItems();
        
        }


        private void btndeleteitem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("File does not exist!");
                return;
            }

            // Check if an item is selected
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an item first!");
                return;
            }

            // Get selected item
            string selectedItem = listBox1.SelectedItem.ToString();

            string[] lines = File.ReadAllLines(filePath);

            List<string> newLines = new List<string>();

            bool deleted = false;

            // Keep all items except the selected one
            foreach (string line in lines)
            {
                if (!deleted && line == selectedItem)
                {
                    deleted = true;
                    continue;
                }

                newLines.Add(line);
            }

            // Save remaining items back to file
            File.WriteAllLines(filePath, newLines.ToArray());

            MessageBox.Show("Item deleted successfully!");

            // Refresh ListBox
            LoadItems();

        }

        private void btndeletefile_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                // Ask user before deleting
                DialogResult answer = MessageBox.Show(
                    "Are you sure you want to delete this file?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes)
                {
                    // Delete file from its location
                    File.Delete(filePath);

                    listBox1.Items.Clear();

                    MessageBox.Show("File deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }
    }
}
     

