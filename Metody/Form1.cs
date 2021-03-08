using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double vzdalenost(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(x1 - x2), 2) + Math.Pow(Math.Abs(y1 - y2), 2));
        }

        double mocnina(int a, int b)
        {
            double vysledek = 1;
            if (b > 0)
            {
                for (int i = 0; i < b; ++i)
                {
                    vysledek *= a;
                }
            }
            else if (b < 0)
            {
                for (int i = 0; i > b; --i)
                {
                    vysledek /= a;
                }
            }
            return vysledek;
        }

        double faktorial(double a)
        {
            double vysledek = 1;
            while (a > 0)
            {
                vysledek *= a;
                --a;
            }
            return vysledek;
        }

        int soucet(int a, int b)
        {
            int soucet = 0;
            soucet = a + b;
            return soucet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox1.Text);
            int x2 = Convert.ToInt32(textBox3.Text);
            int y1 = Convert.ToInt32(textBox2.Text);
            int y2 = Convert.ToInt32(textBox4.Text);
            label1.Text = "Vzdalenost je: " + vzdalenost(x1, y1, x2, y2).ToString();

            int a = Convert.ToInt32(textBox5.Text);
            int b = Convert.ToInt32(textBox6.Text);
            label2.Text = "Mocnina je: " + mocnina(a, b).ToString();

            double a2 = Convert.ToDouble(textBox7.Text);
            label3.Text = "Faktorial je: " + faktorial(a2).ToString();

            int a3 = Convert.ToInt32(textBox8.Text);
            int b3= Convert.ToInt32(textBox9.Text);
            label4.Text = "Soucet je: " + soucet(a3, b3).ToString();

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
