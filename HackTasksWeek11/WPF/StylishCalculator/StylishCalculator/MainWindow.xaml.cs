using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace StylishCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string Input = "";
        private List<double> listOfValues = new List<double>();
        private string sign = "";
        int k = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonfor1_Click(object sender, RoutedEventArgs e)
        {
            //result of +-*/
            Number value1 = new Number(Input);
            listOfValues.Add(value1);
            Input = "";
            Button senderButton = sender as Button;
            sign = (string)senderButton.Content;
            textBox1.Text += sign;
            buttonforDivide.IsEnabled = false;
            buttonforMinus.IsEnabled = false;
            buttonforPlus.IsEnabled = false;
            buttonforMulti.IsEnabled = false;
            buttonforsqrt.IsEnabled = false;
            buttonforLog.IsEnabled = false;
            buttonForEquals.IsEnabled = false;
            buttonforN.IsEnabled = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox1.IsReadOnly = true;
        }  
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //result of log
            double result = 0;
            Number value2 = new Number(Input);
            listOfValues.Insert(0, value2);
            Input = "";
            result = listOfValues[0];
            result = Math.Log(result, 2);
            if (result <= 0)
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
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            //result of ,
            if (!(Input.Contains(",")))
            {
                Button senderButton = sender as Button;
                this.textBox1.Text += ",";
                Input += ",";
            }

        }
        private void button5_Click(object sender, RoutedEventArgs e)
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
            public static implicit operator double (Number num)//implicit number to double cast
            {
                double d = double.Parse(num.ToString());
                return d;
            }
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {
            //result of =
            double result = 0;
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
        private void buttonfor2_Click(object sender, RoutedEventArgs e)
        {
            //result 1234567890 buttons
            Button senderButton = sender as Button;
            this.textBox1.Text += senderButton.Content;
            Input += senderButton.Content;
            buttonforDivide.IsEnabled = true;
            buttonforMinus.IsEnabled = true;
            buttonforPlus.IsEnabled = true;
            buttonforMulti.IsEnabled = true;
            buttonforsqrt.IsEnabled = true;
            buttonforLog.IsEnabled = true;
            buttonForEquals.IsEnabled = true;
            buttonforN.IsEnabled = true;
        
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            
            if ( k==0)
            {
                ResourceDictionary dict = new ResourceDictionary();
                dict.Source = new Uri("Blue.xaml", UriKind.Relative);
                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(dict);
                k = 1;
            }
            else if (k == 1)
            {
                ResourceDictionary dict = new ResourceDictionary();
                dict.Source = new Uri("DarkTheme.xaml", UriKind.Relative);
                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(dict);
                k = 2;
            }
            else if(k==2)
            {

                Application.Current.Resources.MergedDictionaries.Clear();
                k = 0;

            }
        }
    }
}
