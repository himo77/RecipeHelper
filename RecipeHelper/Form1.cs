using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius = 0;
            //Trying to parse the Celsius text box as a decimal value.
            if(!double.TryParse(this.txtCelsius.Text, out celsius))
            {
                //If the parsing fails, prompting user with error message
                MessageBox.Show("Please enter a valid numeric value for celsius.", "Conversion Failed");
            }
            else
            {
                //Converting celsius to fahrenheit
                double fahrenheit = ((celsius / 5) * 9) + 32;
                this.txtFahrenheit.Text = fahrenheit.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double millilitres = 0;
            //Trying to parse the Millilitres text box as a decimal value.
            if (!double.TryParse(this.txtMililitres.Text, out millilitres))
            {
                //If the parsing fails, prompting user with error message
                MessageBox.Show("Please enter a valid numeric value for Millilitres.", "Conversion Failed");
            }
            else
            {
                //Converting millilitres to cups
                double cups = millilitres / 263.59;
                this.txtCups.Text = cups.ToString();
            }
        }
    }
}
