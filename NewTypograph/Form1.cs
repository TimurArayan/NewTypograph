using NewTypograph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTypograph
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Начало формы
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка "Правила"
        /// </summary>
        void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        /// <summary>
        /// Кнопка "Исправить"
        /// </summary>
        void button1_Click(object sender, EventArgs e)
        {
            Rule0_1();
            Rule0_2();
            Rule1();
            Rule2();
            Rule3();
            Rule4();
            Rule5();
            Rule6();
        }

        /// <summary>
        /// Правило 0
        /// </summary>
        public void Rule0_1()
        {
            char[] symbols = new char[] { '.', '?', '!', '…', ',', ';', ':', ')', '»', ' ' };
            string a = richTextBox1.Text;
            while (symbols.Contains(a[0]) != false)
            {
                a = a.Remove(0, 1);
                richTextBox1.Text = a;
            }
        }

        /// <summary>
        /// Правило 1
        /// </summary>
        public void Rule0_2()
        {
            bool test(string b)
            {
                for (int i = 0; i < b.Length - 1; i++)
                {
                    if (b[i].Equals(' ') && b[i + 1].Equals(' '))
                    {
                        return false;
                    }
                }
                return true;
            }
            string a = richTextBox1.Text;
            while (test(a) != true)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i].Equals(' ') && a[i + 1].Equals(' '))
                    {
                        a = a.Remove(i, 1);
                    }
                }
            }
            richTextBox1.Text = a;
        }

        /// <summary>
        /// Правило 2
        /// </summary>
        public void Rule2()
        {
            bool test(string b)
            {
                for (int i = 0; i < b.Length - 2; i++)
                {
                    if (b[i].Equals('.') && b[i + 1].Equals('.') && b[i + 2].Equals('.'))
                    {
                        return false;
                    }
                }
                return true;
            }
            string a = richTextBox1.Text;
            while (test(a) != true)
            {
                for (int i = 0; i < a.Length - 2; i++)
                {
                    if (a[i].Equals('.') && a[i + 1].Equals('.') && a[i + 2].Equals('.'))
                    {
                        a = a.Remove(i, 1);
                        a = a.Remove(i, 1);
                        a = a.Remove(i, 1);
                        a = a.Insert(i, "…");
                    }
                }
            }
            if (a[a.Length - 1].Equals(' '))
            {
                a = a.Remove(a.Length - 1, 1);
            }
            richTextBox1.Text = a;
        }


        /// <summary>
        /// Правило 3
        /// </summary>
        public void Rule3()
        {
            string a = richTextBox1.Text;
            for (int i = 0; i < a.Length; i++)
            {
                if (i == a.Length - 1)
                {
                    if (a[i].Equals('-'))
                    {
                        a = a.Remove(i, 1);
                        richTextBox1.Text = a;
                    }
                }
                else
                {
                    if (a[i].Equals('-') && a[i - 1].Equals(' ') && a[i + 1].Equals(' ') == false)
                    {
                        a = a.Remove(i - 1, 1);
                        richTextBox1.Text = a;
                    }
                    if (a[i].Equals('-') && a[i - 1].Equals(' ') == false && a[i + 1].Equals(' '))
                    {
                        a = a.Remove(i + 1, 1);
                        richTextBox1.Text = a;
                    }
                    if (a[i].Equals('-') && a[i - 1].Equals(' ') && a[i + 1].Equals(' '))
                    {
                        a = a.Remove(i - 1, 1);
                        a = a.Remove(i, 1);
                        richTextBox1.Text = a;
                    }
                }
            }
        }

        /// <summary>
        /// Правило 4
        /// </summary>
        public void Rule4()
        {
            char[] symbols = new char[] { '.', '?', '!', '…', ',', ';', ':' };
            string a = richTextBox1.Text;
            for (int i = 0; i < a.Length; i++)
            {
                if (symbols.Contains(a[i]))
                {

                    if (i != a.Length - 1)
                    {
                        if (a[i - 1].Equals(' ') && a[i + 1].Equals(' '))
                        {
                            a = a.Remove(i - 1, 1);
                            richTextBox1.Text = a;
                        }
                        if (a[i + 1].Equals(' ') == false && a[i - 1].Equals(' ') == false)
                        {
                            a = a.Insert(i + 1, " ");
                            richTextBox1.Text = a;
                        }
                        if (a[i + 1].Equals(' ') == false && a[i - 1].Equals(' '))
                        {
                            a = a.Remove(i - 1, 1);
                            a = a.Insert(i, " ");
                            richTextBox1.Text = a;
                        }
                        Rule0_2();
                    }
                    else if (i == a.Length - 1)
                    {
                        if (a[i - 1].Equals('.'))
                        {

                        }
                        else
                        {
                            a = a.Remove(i - 1, 1);
                            richTextBox1.Text = a;
                        }
                    }
                }
                if (a[i].Equals('('))
                {
                    if (i != a.Length - 1)
                    {
                        if (a[i - 1].Equals(' ') == false && a[i + 1].Equals(' '))
                        {
                            a = a.Remove(i + 1, 1);
                            richTextBox1.Text = a;

                        }
                        if (a[i - 1].Equals(' ') && a[i + 1].Equals(' ') == false)
                        {
                            a = a.Remove(i - 1, 1);
                            richTextBox1.Text = a;
                        }
                        if (a[i - 1].Equals(' ') && a[i + 1].Equals(' '))
                        {
                            a = a.Remove(i - 1, 1);
                            a = a.Remove(i, 1);
                            richTextBox1.Text = a;
                        }
                    }
                    else if (i == a.Length - 1)
                    {
                        a = a.Remove(i, 1);
                        richTextBox1.Text = a;
                    }
                }
                if (a[i].Equals(')'))
                {
                    if (i != a.Length - 1)
                    {
                        if (a[i - 1].Equals(' ') && a[i + 1].Equals(' ') == false)
                        {
                            a = a.Remove(i - 1, 1);
                            a = a.Insert(i, " ");
                            richTextBox1.Text = a;
                        }
                        if (a[i - 1].Equals(' ') && a[i + 1].Equals(' '))
                        {
                            a = a.Remove(i - 1, 1);
                            richTextBox1.Text = a;
                        }
                        if (a[i - 1].Equals(' ') == false && a[i + 1].Equals(' ') == false)
                        {
                            a = a.Insert(i + 1, " ");
                            richTextBox1.Text = a;
                        }

                    }
                }
                if (a[i].Equals('«'))
                {
                    if (i != a.Length - 1 && i != 0)
                    {
                        if (a[i - 1].Equals(' ') == false && a[i + 1].Equals(' '))
                        {
                            a = a.Remove(i + 1, 1);
                            richTextBox1.Text = a;

                        }
                        if (a[i - 1].Equals(' ') && a[i + 1].Equals(' ') == false)
                        {
                            a = a.Remove(i - 1, 1);
                            richTextBox1.Text = a;
                        }
                        if (a[i - 1].Equals(' ') && a[i + 1].Equals(' '))
                        {
                            a = a.Remove(i - 1, 1);
                            a = a.Remove(i, 1);
                            richTextBox1.Text = a;
                        }
                    }
                    else if (i == a.Length - 1)
                    {
                        a = a.Remove(i, 1);
                        richTextBox1.Text = a;
                    }
                    else if (i == 0)
                    {
                        if (a[i + 1].Equals(' '))
                        {
                            a = a.Remove(i + 1, 1);
                            richTextBox1.Text = a;
                        }
                    }
                }
                if (a[i].Equals('»'))
                {
                    if (i != a.Length - 1)
                    {
                        if (a[i - 1].Equals(' ') && a[i + 1].Equals(' ') == false)
                        {
                            a = a.Remove(i - 1, 1);
                            a = a.Insert(i, " ");
                            richTextBox1.Text = a;
                        }
                        if (a[i - 1].Equals(' ') && a[i + 1].Equals(' '))
                        {
                            a = a.Remove(i - 1, 1);
                            richTextBox1.Text = a;
                        }
                        if (a[i - 1].Equals(' ') == false && a[i + 1].Equals(' ') == false)
                        {
                            a = a.Insert(i + 1, " ");
                            richTextBox1.Text = a;
                        }
                    }
                    else
                    {
                        if (a[i - 1].Equals(' '))
                        {
                            a = a.Remove(i - 1, 1);
                            richTextBox1.Text = a;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Праввило 6
        /// </summary>
        public void Rule6()
        {
            string a = richTextBox1.Text;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Equals('и') || a[i].Equals('И'))
                {
                    if (a[i].Equals('и'))
                    {
                        a = a.Remove(i, 1);
                        a = a.Insert(i, "й");
                        richTextBox1.Text = a;
                    }
                    if (a[i].Equals('И'))
                    {
                        a = a.Remove(i, 1);
                        a = a.Insert(i, "Й");
                        richTextBox1.Text = a;
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// Правило 5
        /// </summary>
        public void Rule5()
        {
            string Zam(char number)
            {
                if (number.Equals('0'))
                {
                    return "ноль";
                }
                else if (number.Equals('1'))
                {
                    return "один";
                }
                else if (number.Equals('2'))
                {
                    return "два";
                }
                if (number.Equals('3'))
                {
                    return "три";
                }
                else if (number.Equals('4'))
                {
                    return "четыре";
                }
                else if (number.Equals('5'))
                {
                    return "пять";
                }
                else if (number.Equals('6'))
                {
                    return "шесть";
                }
                else if (number.Equals('7'))
                {
                    return "семь";
                }
                else if (number.Equals('8'))
                {
                    return "восемь";
                }
                else if (number.Equals('9'))
                {
                    return "девять";
                }
                else
                {
                    return null;
                }
            }

            /////

            string a = richTextBox1.Text;
            for (int i = 0; i < a.Length; i++)
            {
                if (Char.IsDigit(a[i]))
                {
                    if (i != 0)
                    {
                        string number = Zam(a[i]);
                        a = a.Remove(i, 1);
                        a = a.Insert(i, number);
                        richTextBox1.Text = a;
                    }
                    else
                    {
                        string number = Zam(a[i]);
                        string firstletter = number[0].ToString().ToUpper();
                        number = number.Remove(0, 1);
                        number = number.Insert(0, firstletter);
                        a = a.Remove(i, 1);
                        a = a.Insert(i, number);
                        richTextBox1.Text = a;
                    }
                }
            }

        }

        public void Rule1()
        {
            string a = richTextBox1.Text;
            int z = 0;
            for (int i = 0; i < a.Length; i++)
            {

                if (i == 0)
                {
                    if (a[i].Equals('"'))
                    {
                        a = a.Remove(i, 1);
                        a = a.Insert(0, "«");
                        z += 1;
                    }
                }
                else
                {
                    if (a[i].Equals('"'))
                    {
                        a = a.Remove(i, 1);
                        if (z % 2 == 0)
                        {
                            a = a.Insert(i, "«");
                        }
                        else
                        {
                            a = a.Insert(i, "»");

                        }
                        z += 1;
                    }
                }
            }
            richTextBox1.Text = a;
        }
    }
}
