using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            const int QUARTER_VALUE = 25;
            const int DIME_VALUE = 10;
            const int NICKEL_VALUE = 5;
            const int PENNY_VALUE = 1;

            int numberOfQuarters = int.Parse(quarterTextBox.Text);
            int numberOfDimes = int.Parse(dimeTextBox.Text);
            int numberOfNickels = int.Parse(nickelTextBox.Text);
            int numberOfPennies = int.Parse(pennyTextBox.Text);
            int total = (QUARTER_VALUE * numberOfQuarters) +
                (DIME_VALUE * numberOfDimes) +
                (NICKEL_VALUE * numberOfNickels) +
                (PENNY_VALUE * numberOfPennies);
            
            if ( total == 100)
            {
                MessageBox.Show("You Won");
            }
            else if ( total < 100)
            {
                MessageBox.Show("Number Too Low");
            }
            else if ( total > 100)
            {
                MessageBox.Show("Number Too High");
            }

        }
    }
}
