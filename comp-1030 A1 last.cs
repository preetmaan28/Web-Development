using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String classa, classb, classc;
            double a, b, c;

            classa = textBox1.Text;
            classb = textBox2.Text;
            classc = textBox3.Text;

            try { 
            a = double.Parse(classa);
            b = double.Parse(classb);
           c = double.Parse(classc);

           
                double cal;
                //revenue of Class A tickets
                cal = a * 15;
                //For currency formatting-"C"
                textBox4.Text = cal.ToString("C");

                double cal1;
                //revenue of Class B tickets
                cal1 = b * 12;
                textBox5.Text = cal1.ToString("C");

                double cal2;
                //revenue of Class C tickets
                cal2 = c * 9;
                textBox6.Text = cal2.ToString("C");

                double total;
                //total revenue Generated
                total = cal + cal1 + cal2;
                textBox7.Text = total.ToString("C");
            }
            //Exception handling
            catch(Exception error)
            {
                MessageBox.Show("Please put all values accurately");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            this.Close();
        }
    }
}
