using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kg_to_pounds_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtConvert.Text = "";
            txtConverted.Text = "";

            radKilogram1.Checked = false;
            radPounds2.Checked = false;
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            double Kilogram = Convert.ToDouble(txtConvert.Text);
            double Pounds = Convert.ToDouble(txtConvert.Text);
            double Converted = 0.0;

            if(radKilogram1.Checked)
            {
                Converted = Kilogram * 2.205;
            }
            else
                if(radPounds2.Checked)
            {
                Converted = Pounds / 2.205;
            }
            txtConverted.Text = Converted.ToString("0.000");
        }
    }
}