using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelEconomy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MileageTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void GallonsUsedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MPGBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void CalculateMPG_Click(object sender, EventArgs e)
        {
            try 
            {
                double Miles, Gallons, MPG;
                Miles = double.Parse(MileageTextBox.Text);
                Gallons = double.Parse(GallonsUsedTextBox.Text);

                MPG = Miles / Gallons;
                MPGBox.Text = MPG.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
