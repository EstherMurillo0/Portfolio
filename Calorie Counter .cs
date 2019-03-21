using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Counter
{
    public partial class Form1 : Form
    {
        int totalCalories = 0;
        const int banana_value = 115;
        const int apple_value = 80;
        const int orange_value = 90;
        const int pear_value = 120;
         
        public Form1()
        {
            InitializeComponent();
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            totalCaloriesLabel.Text = " ";
        }

        private void totalCaloriesLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void pearPictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += pear_value;
            totalCaloriesLabel.Text = totalCalories.ToString();
        }

        private void bananaPictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += banana_value;
            totalCaloriesLabel.Text = totalCalories.ToString();
        }

        private void orangePictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += orange_value;
            totalCaloriesLabel.Text = totalCalories.ToString();
        }

        private void applePictureBox_Click(object sender, EventArgs e)
        {
            totalCalories += apple_value;
            totalCaloriesLabel.Text = totalCalories.ToString();
        }
    }
}
