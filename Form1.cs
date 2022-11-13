using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationRerformed = "";
        bool isOerationRerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void button_click(object sender, EventArgs e)
        {
            if (txtResult.Text =="0" || (isOerationRerformed))
                txtResult.Clear();
            isOerationRerformed = false;
            Button button =(Button)sender;
            if(button.Text ==".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text += button.Text;

            }
            else
            {
                txtResult.Text +=button.Text;
            }

           
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button =(Button)sender;
            operationRerformed= button.Text;    
            resultValue=Double.Parse(txtResult.Text);   
            lblOP.Text =resultValue + "" + operationRerformed;
            isOerationRerformed= true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (operationRerformed == "+")
            {
                txtResult.Text =(resultValue + double.Parse (txtResult.Text)).ToString();   
            }
            else if (operationRerformed == "-")
            {
                txtResult.Text = (resultValue - double.Parse(txtResult.Text)).ToString();
            }
            else if(operationRerformed == "X")
            {
                txtResult.Text = (resultValue * double.Parse(txtResult.Text)).ToString();
            }
            else
            {
                txtResult.Text = (resultValue / double.Parse(txtResult.Text)).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            resultValue = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length >0)
                txtResult.Text =txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            if (txtResult.Text == "")
                txtResult.Text = "0";        }
    }
}
