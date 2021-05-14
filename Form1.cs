using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double FirstNumber = 0;
        string Operation = "";
        bool isOperationPerformed = false;
        decimal EndResult = 0;
        decimal MemoryStore = 0;
        bool Memory;
        public Calculator()
        {
            InitializeComponent();
        }


        //Number buttons
        private void number1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))

                textBox1.Clear();

            Button btn = (Button)sender;
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))

                textBox1.Clear();

            Button btn = (Button)sender;
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))

                textBox1.Clear();

            Button btn = (Button)sender;
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))

                textBox1.Clear();

            Button btn = (Button)sender;
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))

                textBox1.Clear();

            Button btn = (Button)sender;
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))

                textBox1.Clear();

            Button btn = (Button)sender;
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))

                textBox1.Clear();

            Button btn = (Button)sender;
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))

                textBox1.Clear();

            Button btn = (Button)sender;
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))

                textBox1.Clear();

            Button btn = (Button)sender;
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))

                textBox1.Clear();

            Button btn = (Button)sender;
            isOperationPerformed = false;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        //Dot button(".")
        private void dotbutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if
                 (!textBox1.Text.Contains("."))

                    textBox1.Text = textBox1.Text + ".";
            }
            else
                textBox1.Text = textBox1.Text + btn.Text;



        }

        //Addition)
        private void addbutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (FirstNumber != 0)
            {

                equalbtn.PerformClick();
                FirstNumber = Double.Parse(textBox1.Text);
                Operation = btn.Text;
                isOperationPerformed = true;
                label1.Text = FirstNumber + "" + Operation;
            }
            else
            {
                FirstNumber = Double.Parse(textBox1.Text);
                Operation = btn.Text;
                isOperationPerformed = true;
                label1.Text = FirstNumber + "" + Operation;
            }
        }

        //Substraction 
        private void subbutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (FirstNumber != 0)
            {

                equalbtn.PerformClick();
                FirstNumber = Double.Parse(textBox1.Text);
                Operation = btn.Text;
                isOperationPerformed = true;
                label1.Text = FirstNumber + "" + Operation;
            }
            else
            {
                FirstNumber = Double.Parse(textBox1.Text);
                Operation = btn.Text;
                isOperationPerformed = true;
                label1.Text = FirstNumber + "" + Operation;
            }
        }

        //Multiplication button
        private void multbutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (FirstNumber != 0)
            {

                equalbtn.PerformClick();
                FirstNumber = Double.Parse(textBox1.Text);
                Operation = btn.Text;
                isOperationPerformed = true;
                label1.Text = FirstNumber + "" + Operation;
            }
            else
            {
                FirstNumber = Double.Parse(textBox1.Text);
                Operation = btn.Text;
                isOperationPerformed = true;
                label1.Text = FirstNumber + "" + Operation;
            }
        }

        //Division button
        private void divbutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (FirstNumber != 0)
            {

                equalbtn.PerformClick();
                FirstNumber = Double.Parse(textBox1.Text);
                Operation = btn.Text;
                isOperationPerformed = true;
                label1.Text = FirstNumber + "" + Operation;
            }
            else
            {
                FirstNumber = Double.Parse(textBox1.Text);
                Operation = btn.Text;
                isOperationPerformed = true;
                label1.Text = FirstNumber + "" + Operation;
            }
        }

        //Equal button
        private void equalbtn_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result = 0;

            SecondNumber = Double.Parse(textBox1.Text);

            if (Operation == "+")
            {
                textBox1.Text = (FirstNumber + Double.Parse(textBox1.Text)).ToString();

            }
            if (Operation == "-")
            {
                textBox1.Text = (FirstNumber - Double.Parse(textBox1.Text)).ToString();
            }
            if (Operation == "*")
            {
                textBox1.Text = (FirstNumber * Double.Parse(textBox1.Text)).ToString();
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Font = new Font("Arial", 12, FontStyle.Bold);
                    textBox1.ForeColor = Color.Red;
                    textBox1.Text = "Няма деление на нула";
                    label1.Text = "ГРЕШКА!!!";
                    label1.Font = new Font("Arial", 14, FontStyle.Bold);

                    return;                   
                         
                }
                else
                {
                    textBox1.Text = (FirstNumber / Double.Parse(textBox1.Text)).ToString();
                }
                FirstNumber = double.Parse(textBox1.Text);
                label1.Text = "";
            }
        }

        //Clear button
        private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            FirstNumber = 0;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }


        //Memory clear button
        private void MC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            MemoryStore = 0;
            MC.Enabled = true;
            MR.Enabled = true;

        }

        //Memory recall button
        private void MR_Click(object sender, EventArgs e)
        {
            textBox1.Text = MemoryStore.ToString();
            Memory = true;


        }

        //Memory add button
        private void Madd_Click(object sender, EventArgs e)
        {
            MemoryStore += Decimal.Parse(textBox1.Text);

        }

        //Memory subtract button
        private void MMinus_Click(object sender, EventArgs e)
        {
            MemoryStore -= Decimal.Parse(textBox1.Text);
        }

        //Memory store
        private void MemoryST_Click(object sender, EventArgs e)
        {
            MemoryStore = Decimal.Parse(textBox1.Text);
            MC.Enabled = true;
            MR.Enabled = true;
            Memory = true;

        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {
            Double squareroot = Math.Sqrt(Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(squareroot);

        }

        private void SquareRoot_Click_1(object sender, EventArgs e)
        {
            double squareroot;
            bool hasDecimal = false;

            if (textBox1.Text.Length != 0)

            {
                squareroot = System.Double.Parse(textBox1.Text);
                squareroot = System.Math.Sqrt(squareroot);
                textBox1.Text = squareroot.ToString();
                hasDecimal = false;
                



            }
        }



    }
}
    


