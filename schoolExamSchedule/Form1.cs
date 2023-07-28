using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace schoolExamSchedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int exam1, exam2, exam3, project, average;
            string basePoint = "";
            exam1 = Convert.ToInt32(textBox1.Text);
            exam2 = Convert.ToInt32(textBox2.Text);
            exam3 = Convert.ToInt32(textBox3.Text);
            project = Convert.ToInt32(textBox4.Text);

            average = (((exam1 + exam2 + exam3) / 3) + project) / 2;

            if(exam1 >= 101 || exam2 >= 101 || exam3 >= 101 || project >= 101)
            {
                MessageBox.Show("More than 100 numbers are not accepted");
            }
            else
            {
                if (average >= 50)
                {
                    basePoint = "You passed";
                }
                else
                {
                    basePoint = "You stayed";
                }


                textBox5.Text = average.ToString() + " " + basePoint;
            }           
        }
    }
}
