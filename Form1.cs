using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            string classA, classB, classC;
            double A, B, C;

            try
            {
                classA = textBox1.Text;
                classB = textBox2.Text;
                classC = textBox3.Text;
                // 
                A = double.Parse(classA);
                B = double.Parse(classB);
                C = double.Parse(classC);
                //
                double calcul1;
                calcul1 = A * 15;
                textBox4.Text = calcul1.ToString("C");

                double calcul2;
                calcul2 = B * 12;
                textBox5.Text = calcul2.ToString("C");

                double calcul3;
                calcul3 = C * 9;
                textBox6.Text = calcul3.ToString("C");

                double total;
                total = calcul1 + calcul2 + calcul3;
                textBox7.Text = total.ToString("C");

            }

            catch (Exception ab)
            {
                MessageBox.Show("Error");
            }
        }





        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //content
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //close button
            this.Close();
        }
    
    }
    }
