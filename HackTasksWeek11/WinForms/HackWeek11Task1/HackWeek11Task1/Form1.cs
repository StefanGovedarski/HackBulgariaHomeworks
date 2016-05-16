using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace HackWeek11Task1
{
    //the Number class is at the bottom
    public partial class Calculator : Form
    {
        private string Input = "";
        private List<double> listOfValues = new List<double>();
        private string sign = "";


        public Calculator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //result 1234567890 buttons
            Button senderButton = sender as Button;
            this.textBox1.Text += senderButton.Text;
            Input += senderButton.Text;
            buttonDividePressed.Enabled = true;
            buttonMinusPressed.Enabled = true;
            buttonPlusPressed.Enabled = true;
            buttonMultiplyPressed.Enabled = true;
            buttonSqrtPressed.Enabled = true;
            buttonLog2Pressed.Enabled = true;
            buttonEqualsPressed.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //result of +-*/
            Number value1 = new Number(Input);
            listOfValues.Add(value1);
            Input = "";
            Button senderButton = sender as Button;
            sign = senderButton.Text;
            textBox1.Text += sign;
            buttonDividePressed.Enabled = false;
            buttonMinusPressed.Enabled = false;
            buttonPlusPressed.Enabled = false;
            buttonMultiplyPressed.Enabled = false;
            buttonSqrtPressed.Enabled = false;
            buttonLog2Pressed.Enabled = false;
            buttonEqualsPressed.Enabled = false;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //result of log
            double result = 0;
            Number value2 = new Number(Input);
            listOfValues.Insert(0,value2);
            Input = "";
            result = listOfValues[0];
            result = Math.Log(result, 2);
            if(result <= 0)
            {
                string s = "you cant use log for value <=0";
                textBox1.Text = s;
            }
            else
            {
                textBox1.Text = result.ToString();
                Input = result.ToString();
            }
            listOfValues.RemoveAt(0);


        }
        private void button4_Click(object sender, EventArgs e)
        {
            //result of ,
            if(!(Input.Contains(",")))
            {
                Button senderButton = sender as Button;
                this.textBox1.Text += ",";
                Input += ",";
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            //result of sqrt
            listOfValues.Clear();
            double result = 0;
            Number value2 = new Number(Input);
            listOfValues.Add(value2);
            Input = "";
            result = listOfValues.Last<double>();
            result = Math.Sqrt(result);
            Input = result.ToString();
            textBox1.Text = result.ToString();
            listOfValues.RemoveAt(0);

        }
        private void button21_Click(object sender, EventArgs e)
        {
            //result of =
            double result =0;
            Number value2 = new Number(Input);
            listOfValues.Add(value2);
            Input = "";
            string textfromcalc = textBox1.Text;
                if (listOfValues.Count >= 2)
                {
                    if (sign == "+")
                    {
                        if (listOfValues[0] + listOfValues[1] <= double.MaxValue && listOfValues[0] + listOfValues[1] >= double.MinValue)
                        {
                            result = listOfValues[0] + listOfValues[1];
                            Input = result.ToString();
                            textBox1.Text = Input;
                            sign = "";
                        }
                        else
                        {
                            string s = "The result is too big";
                            textBox1.Text = s;
                        }
                    }
                    if (sign == "-")
                    {
                        if (listOfValues[0] - listOfValues[1] <= double.MaxValue && listOfValues[0] - listOfValues[1] >= double.MinValue)
                        {
                            result = listOfValues[0] - listOfValues[1];
                            Input = result.ToString();
                            textBox1.Text = Input;
                            sign = "";
                        }
                        else
                        {
                            string s = "The result is too big";
                            textBox1.Text = s;
                        }
                    }
                    if (sign == "*")
                    {
                        if (listOfValues[0] * listOfValues[1] <= double.MaxValue && listOfValues[0] * listOfValues[1] >= double.MinValue)
                        {
                            result = listOfValues[0] * listOfValues[1];
                            Input = result.ToString();
                            textBox1.Text = Input;
                            sign = "";
                        }
                        else
                        {
                            string s = "The result is too big";
                            textBox1.Text = s;
                        }
                    }
                    if (sign == "/")
                    {
                        if ((listOfValues[0] / listOfValues[1] <= double.MaxValue && listOfValues[0] / listOfValues[1] >= double.MinValue))
                        {

                            result = listOfValues[0] / listOfValues[1];
                            Input = result.ToString();
                            textBox1.Text = Input;
                            sign = "";

                        }
                        else
                        {
                            string s = "NoN";
                            textBox1.Text = s;
                        }
                    }
                    listOfValues.RemoveAt(0);
                    listOfValues.RemoveAt(0);
                }
                else
                {
                    string s = "There is not enough value in to do a calculation.";
                    textBox1.Text = s;
            }
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
        }

    }
    class Number
    {
        private string number;

        public Number(string num)
        {
            this.number = num;
        }
        public override string ToString()
        {
            return this.number;
        }
        public static implicit operator double(Number num)//implicit number to double cast
        {
            double d =double.Parse( num.ToString());
            return d;
        }

    }
}
