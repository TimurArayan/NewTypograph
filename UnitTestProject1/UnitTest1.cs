using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewTypograph;
using System;
using System.Security.AccessControl;
using NewTypograph;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string b = " . . . .  .. .    Я пришел";
            string expected = "Я пришел";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule0_1();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod16()
        {
            //arrange
            string b = "Я     пришел       вчера";
            string expected = "Я пришел вчера»";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule0_2();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            string b = "Он сказал: " + '\u0022' + "Я приду завтра." + '\u0022';
            string expected = "Он сказал: «Я приду завтра.»";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule1();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            string b = "Я пришел...";
            string expected = "Я пришел…";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule2();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            string b = "Я пошел на юго -запад";
            string expected = "Я пошел на юго-запад";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule3();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //arrange
            string b = "Я пошел на юго- запад";
            string expected = "Я пошел на юго-запад";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule3();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //arrange
            string b = "Я пошел на юго - запад";
            string expected = "Я пошел на юго-запад";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule3();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //arrange
            string b = "Я пришел-";
            string expected = "Я пришел";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule3();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //arrange
            string b = "Привет , меня зовут Тимур";
            string expected = "Привет, меня зовут Тимур";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule4();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //arrange
            string b = "Привет,меня зовут Тимур";
            string expected = "Привет, меня зовут Тимур";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule4();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //arrange
            string b = "Привет ,меня зовут Тимур";
            string expected = "Привет, меня зовут Тимур";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule4();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod11()
        {
            string b = "Такая врзможность была только 2 дня в неделю (понедельник , вторник)";
            string expected = "Такая врзможность была только 2 дня в неделю(понедельник, вторник)";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule4();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod12()
        {
            string b = "Такая врзможность была только 2 дня в неделю( понедельник ,вторник)";
            string expected = "Такая врзможность была только 2 дня в неделю(понедельник, вторник)";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule4();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethod13()
        {
            string b = "Такая врзможность была только 2 дня в неделю ( понедельник , вторник)";
            string expected = "Такая врзможность была только 2 дня в неделю(понедельник, вторник)";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule4();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod14()
        {
            string b = "Улетело 9 птиц";
            string expected = "Улетело девять птиц";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule5();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod15()
        {
            string b = "Интригующий";
            string expected = "Йнтригующий";

            //act
            Form1 f = new Form1();
            f.richTextBox1.Text = b;
            f.Rule6();
            string actual = f.richTextBox1.Text;

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
