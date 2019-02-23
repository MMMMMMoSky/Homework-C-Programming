using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_WinFormApp
{
    public partial class Form1 : Form
    {
        private int a, b;
        private bool ok_a, ok_b;

        private void RHS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToInt32(RHS.Text);
                ok_b = true;
            }
            catch (System.FormatException)
            {
                ok_b = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ok_a && ok_b)
                button1.Text = Convert.ToString(a * b);
            else
                button1.Text = "Invalid";
        }

        public Form1()
        {
            InitializeComponent();
            a = 0;
            b = 0;
            ok_a = false;
            ok_b = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(LHS.Text);
                ok_a = true;
            }
            catch (System.FormatException)
            {
                ok_a = false;
            }
        }
    }
}
