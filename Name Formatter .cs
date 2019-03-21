using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_Formatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void format1_Click(object sender, EventArgs e)
        {
            string output;

            output = titleTextBox.Text + ". " + firstNameTextBox.Text + " " + middleNameTextBox.Text + " " + lastNameTextBox.Text;
            fullNameLabel.Text = output;
        }

        private void format2_Click(object sender, EventArgs e)
        {
            string outputOne;

            outputOne = firstNameTextBox.Text + " " + middleNameTextBox.Text + " " + lastNameTextBox.Text;
            fullNameLabel.Text = outputOne;

        }

        private void format3_Click(object sender, EventArgs e)
        {
            string outputTwo;

            outputTwo = firstNameTextBox.Text + " " + lastNameTextBox.Text;
            fullNameLabel.Text = outputTwo;
        }

        private void format4_Click(object sender, EventArgs e)
        {
            string outputThree;

            outputThree = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " " + middleNameTextBox.Text + ", " + titleTextBox.Text + ".";
            fullNameLabel.Text = outputThree;
        }

        private void format5_Click(object sender, EventArgs e)
        {
            string outputFour;

            outputFour = lastNameTextBox.Text + ", " + firstNameTextBox.Text + " " + middleNameTextBox.Text;
            fullNameLabel.Text = outputFour;
        }

        private void format6_Click(object sender, EventArgs e)
        {
            string outputFive;

            outputFive = lastNameTextBox.Text + ", " + firstNameTextBox.Text;
            fullNameLabel.Text = outputFive;
        }
    }
}
