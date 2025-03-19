using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//CGPA = (Sum of (Grade Points * Course Credits)) / (Total Course Credits)
namespace Cgpa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int coursecredits;
            int gradepoints;
            int totalcredit;
            int credithours;

            if (int.TryParse(textBox1.Text, out coursecredits) && int.TryParse(textBox2.Text, out gradepoints) && int.TryParse(textBox3.Text, out credithours)) ;
            {
                if (credithours > 0)
                {
                    Double sum = gradepoints * coursecredits;
                    Double gpa = sum / (double)totalcredit;
                    Console.WriteLine("Calculated GPA: " + gpa);
                }
                else
                {
                    MessageBox.Show("Error: ");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text=""; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
