using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HackWeek11TextAutoCorrect
{
    public partial class AutoCorrectEditor : Form
    {
        private string filePathName = "../../Dictionary.txt";
        private StringBuilder sb = new StringBuilder();
        private StringBuilder sb2 = new StringBuilder();
        private string[] allWords;
        private string[] textArray;

        public AutoCorrectEditor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //text box
        }
        private void CheckAndSplitMethod()
        {
            if (File.Exists(filePathName))
            {
                sb2 = sb;
                allWords =  File.ReadAllLines(filePathName);
                textArray = sb.ToString().Split(' ' , '.' , ',' , '\n', '?' , '!' , ':' , ';' , '-');
                for(int i=0; i<textArray.Length; i++)
                {
                    if(!(allWords.Contains<string>(textArray[i])))
                    {
                        sb2.Replace(textArray[i], AutoCorrectMethod(textArray[i], allWords));
                    }
                }
            }
            else
            {
                string s = "File not found";
                textBox1.Text = s;
            }
        }
        private string AutoCorrectMethod(string word , string[] dictionary)
        {
            int numberOfDifferencesBetween = 100;
            string actualWord = "a";
            for(int i=0;i<dictionary.Length;i++)
            {
                int tempDif = 0;
                if(word.Length > dictionary[i].Length)
                {
                    tempDif = word.Length - dictionary[i].Length;
                    for(int j=0;j<dictionary[i].Length;j++)
                    {
                        if(word[j]!=dictionary[i][j])
                        {
                            tempDif++;
                        }
                    }
                }
                else
                {
                    tempDif = dictionary[i].Length - word.Length;
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j] != dictionary[i][j])
                        {
                            tempDif++;
                        }
                    }
                }
                if(tempDif<numberOfDifferencesBetween)
                {
                    numberOfDifferencesBetween = tempDif;
                    actualWord = dictionary[i];
                }
            }
            textBox1.Enabled = true;
            return actualWord;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //text box 2
        }

        private void finish_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            sb.Append(textBox1.Text);
            CheckAndSplitMethod();
            textBox2.Text = sb2.ToString();
        }
    }
}
