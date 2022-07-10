using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace EclerxWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);

            int Sum = a + b;
            lbl_Result.Text = $"Addition of Number is : {Sum}";

        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);

            int Mul = a * b;
            lbl_Result.Text = $"Multiplication of Number is : {Mul}";
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);

            int Divide = a / b;
            lbl_Result.Text = $"Division of Number is : {Divide}";
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);

            int Sub = a - b;
            lbl_Result.Text = $"Substraction of Number is : {Sub}";
        }
    }
}
