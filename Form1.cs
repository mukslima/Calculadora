namespace Calculadora
{
    public partial class Calculadoraa : Form
    {
        private string operacao = "";
        private double valor1 = 0;
        private bool operacaoEmAndamento = false;

        public Calculadoraa()
        {
            InitializeComponent();
        }

        private void AdicionarNumero(string numero)
        {
            if (textBox1.Text == "0" || operacaoEmAndamento)
            {
                textBox1.Text = numero;
                operacaoEmAndamento = false;
            }
            else
            {
                textBox1.Text += numero;
            }
        }

        // Botões de números
        private void button1_Click(object sender, EventArgs e) => AdicionarNumero("1");
        private void button2_Click(object sender, EventArgs e) => AdicionarNumero("2");
        private void button3_Click(object sender, EventArgs e) => AdicionarNumero("3");
        private void button4_Click(object sender, EventArgs e) => AdicionarNumero("4");
        private void button5_Click(object sender, EventArgs e) => AdicionarNumero("5");
        private void button6_Click(object sender, EventArgs e) => AdicionarNumero("6");
        private void button7_Click(object sender, EventArgs e) => AdicionarNumero("7");
        private void button8_Click(object sender, EventArgs e) => AdicionarNumero("8");
        private void button9_Click(object sender, EventArgs e) => AdicionarNumero("9");
        private void button10_Click(object sender, EventArgs e) => AdicionarNumero("0");

        // Botões de cálculo
        private void button18_Click(object sender, EventArgs e) => Operacao("X");
        private void button19_Click(object sender, EventArgs e) => Operacao("-");
        private void button21_Click(object sender, EventArgs e) => Operacao("+");
        private void button20_Click(object sender, EventArgs e) => Operacao("/");

        private void Operacao(string op)
        {
            valor1 = double.Parse(textBox1.Text);
            operacao = op;
            operacaoEmAndamento = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double valor2 = double.Parse(textBox1.Text);
            double resultado = 0;

            switch (operacao)
            {
                case "X":
                    resultado = valor1 * valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        MessageBox.Show("Divisão por zero não permitida");
                        return;
                    }
                    break;
                default:
                    return;
            }

            textBox1.Text = resultado.ToString();
            operacaoEmAndamento = true;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBox1.Text);
            valor = -valor;
            textBox1.Text = valor.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBox1.Text);
            valor = valor / 100;
            textBox1.Text = valor.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            valor1 = 0;
            operacao = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Calculadoraa_Load(object sender, EventArgs e)
        {

        }
    }
}
