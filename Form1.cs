using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDoBreno2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //enum é uma lista de opções
        enum Operacao
        {
            Soma,
            Subtrai,
            Divide,
            Multiplica,
            Nenhuma,
            Menos
        }
        //Declaração da variável "ultimaOperacao".
        static Operacao ultimaOperacao = Operacao.Nenhuma;

        public object GettextBoxDisplay { get; private set; }
        public object TextBoxDisplay { get; private set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text =
                    textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }
        }

        private void buttonCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            if(ultimaOperacao == Operacao.Nenhuma)
            {
                ultimaOperacao = Operacao.Soma;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void FazerCalculo(Operacao ultimaOperacao)
        {
            List<double> ListaDeNumeros = new List<double>();

            switch (ultimaOperacao)
            {
                case Operacao.Soma:
                    ListaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] + ListaDeNumeros[1]).ToString();
                    break;
                case Operacao.Subtrai:
                    ListaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] - ListaDeNumeros[1]).ToString();
                    break;
                case Operacao.Divide:
                    ListaDeNumeros = textBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] / ListaDeNumeros[1]).ToString();
                    break;
                case Operacao.Multiplica:
                    ListaDeNumeros = textBoxDisplay.Text.Split('*').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (ListaDeNumeros[0] * ListaDeNumeros[1]).ToString();
                    break;
                case Operacao.Nenhuma:
                    break;
                default:
                    break;
            }
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.Nenhuma)
            {
                ultimaOperacao = Operacao.Menos;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.Nenhuma)
            {
                ultimaOperacao = Operacao.Divide;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
        }

        private void buttonMultiplica_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.Nenhuma)
            {
                ultimaOperacao = Operacao.Multiplica;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            FazerCalculo(ultimaOperacao, GettextBoxDisplay);
        }

        private void FazerCalculo(Operacao ultimaOperacao, object gettextBoxDisplay)
        {
            throw new NotImplementedException();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "8";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
