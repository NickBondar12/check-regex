using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyCheckRegex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string s_re = richTextBox1.Text;
            string s = richTextBox2.Text;
            //List<string> sList = new List<string>();
            //string[] wordsArray = richTextBox2.Text.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (string word in wordsArray)
            //{
            //    sList.Add(word.Trim()); // Удаляем лишние пробелы, если они есть
            //}
            DialogResult res;
            Match match = Regex.Match(s, @s_re);
            if(s != match.ToString())
            {
                res = MessageBox.Show("Continue?", "Wrong regular expression", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (res == DialogResult.Yes)
                {
                    richTextBox1.Focus();
                    richTextBox1.Text = "";
                }
                else
                    this.Close();
            }
            else
            {
                res = MessageBox.Show("Continue?", "Valid regular expression", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    richTextBox1.Focus();
                    richTextBox1.Text = "";
                }
                else
                    this.Close();
            }
        }
    }
}
