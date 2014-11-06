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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            
            int.TryParse(txtFirstNumber.Text, out a);
            int.TryParse(txtSecondNumber.Text, out b);

            int sum = a + b;

            txtResult.Text = sum.ToString();
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            int.TryParse(txtFirstNumber.Text, out a);
            int.TryParse(txtSecondNumber.Text, out b);

            int diff = a - b;


            txtResult.Text = diff.ToString();



            
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            int.TryParse(txtFirstNumber.Text, out a);
            int.TryParse(txtSecondNumber.Text, out b);

            int mul = a * b;

            txtResult.Text = mul.ToString();

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            int.TryParse(txtFirstNumber.Text, out a);
            int.TryParse(txtSecondNumber.Text, out b);

            int div = a / b;


            txtResult.Text = div.ToString();
        }
    
         private void btnStepen_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            int.TryParse(txtFirstNumber.Text, out a);
            int.TryParse(txtSecondNumber.Text, out b);

            double stepen = Math.Pow(a, b);

            txtResult.Text = stepen.ToString();
            {
            }

        }

         private void btnSin_Click(object sender, EventArgs e)
         {
             double a = 0;
             
             double.TryParse(txtFirstNumber.Text, out a);
             
             double sin = Math.Sin(a);

             txtResult.Text = sin.ToString();



         }

         private void btnCos_Click(object sender, EventArgs e)
         {
             double a = 0;
             
             double.TryParse(txtFirstNumber.Text, out a);
             
             double cos = Math.Cos(a);

             txtResult.Text = cos.ToString();
         }
         
         private void btnFct_Click(object sender, EventArgs e)
         {

            int a = 0;
          
            int.TryParse(txtFirstNumber.Text, out a);

            int fact = Factorial(a);
            txtResult.Text = fact.ToString();
        }
         private static int Factorial(int n)
         {
             int res = 1;
             for (int i = 2; i <= n; i++)
             {
                 res *= i;
             }
             return res;
             
         }

        private void btnSqrtB_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;

            double.TryParse(txtFirstNumber.Text, out a);
            double.TryParse(txtSecondNumber.Text, out b);

            double c = 1 / b;
            double radical = Math.Pow(a, c);
            txtResult.Text = radical.ToString();

        }
    }
}