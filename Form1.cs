namespace Calculadora_Poo
{
    public partial class Form1 : Form
    {
        private decimal Resulatdo { get; set; }

        private decimal valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Soma,
            Subtrair,
            Multiplicar,
            Dividir
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void chkTemaEscuro_CheckedChanged(object sender, EventArgs e)
        {
            AplicarTema(chkTemaEscuro.Checked);
        }

        private void AplicarTema(bool escuro)
        {
            if (escuro)
            {
                this.BackColor = Color.FromArgb(30, 30, 30); // cor de fundo escura

                foreach (Control controle in this.Controls)
                {
                    if (controle is Button)
                    {
                        controle.BackColor = Color.DimGray;
                        controle.ForeColor = Color.White;
                    }
                    else if (controle is CheckBox || controle is Label)
                    {
                        controle.ForeColor = Color.White;
                    }
                }
            }
            else
            {
                this.BackColor = Color.White; // Cor de fundo clara

                foreach (Control controle in this.Controls)
                {
                    if (controle is Button)
                    {
                        controle.BackColor = SystemColors.Control;
                        controle.ForeColor = Color.Black;
                    }
                    else if (controle is CheckBox || controle is Label)
                    {
                        controle.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Soma;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "+";
            
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtrair;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicar;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Dividir;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Soma:
                    Resulatdo = valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtrair:
                    Resulatdo = valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicar:
                    Resulatdo = valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Dividir:
                    Resulatdo = valor / Convert.ToDecimal(txtResultado.Text);
                    break;

            }
            txtResultado.Text = Convert.ToString(Resulatdo);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text = ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }
    }
}
