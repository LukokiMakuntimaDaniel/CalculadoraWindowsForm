using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "+";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            texto.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "%";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + ".";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            texto.Text = texto.Text + "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                int tamanho = texto.Text.Length;
                string parteUtil = texto.Text.Substring(0, tamanho - 1);
                texto.Text = parteUtil;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            Double resultado = Convert.ToDouble(table.Compute(texto.Text, String.Empty));
            texto.Text = resultado.ToString();
        }
    }
}
