using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTryagain_Click(object sender, EventArgs e)
        {
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtResult.Text = "";

            radPounds.Checked = false;
            radKilogramm.Checked = false;
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            double Weight = Convert.ToDouble(txtWeight.Text);
            double Height = Convert.ToDouble(txtHeight.Text);
            double Result = 0.0;
            string Result2 = "";

            if(radKilogramm.Checked)
            {
                Result = Weight / (Height * Height);
            }
            else
                if (radPounds.Checked)
            {
                Weight = Weight / 2.205;
                Result = Weight / (Height * Height);
            }

            if (Result < 18.5)
            {
                Result2 = "You are underweight, eat more or something";
            }
            else
                if (Result < 25)
            {
                Result2 = "Congrats you have normal weight";
            }

            else
                if (Result < 30)
            {
                Result2 = "You're overweight, take it easy";
            }
            else
                if (Result >= 30)
            {
                Result2 = "Yhh, you are obese";
            }
                txtResult.Text = "After calculating, iit seems your BMI is:" + Result.ToString("0.0") + "\r\n" + Result2;
        }
    }
}
 