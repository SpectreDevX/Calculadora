namespace Calculadora_Poo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnZero = new Button();
            txtResultado = new TextBox();
            btnIgual = new Button();
            btnTres = new Button();
            btnLimpar = new Button();
            btnSoma = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDivisao = new Button();
            chkTemaEscuro = new CheckBox();
            lblOperacao = new Label();
            btnVirgula = new Button();
            SuspendLayout();
            // 
            // btnSete
            // 
            btnSete.Location = new Point(8, 144);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(101, 58);
            btnSete.TabIndex = 0;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(115, 144);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(101, 58);
            btnOito.TabIndex = 1;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(222, 144);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(101, 58);
            btnNove.TabIndex = 2;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(8, 208);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(101, 58);
            btnQuatro.TabIndex = 3;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(115, 208);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(101, 58);
            btnCinco.TabIndex = 4;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(222, 208);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(101, 60);
            btnSeis.TabIndex = 5;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(8, 272);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(101, 60);
            btnUm.TabIndex = 6;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(115, 272);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(101, 60);
            btnDois.TabIndex = 7;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(115, 338);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(101, 60);
            btnZero.TabIndex = 8;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(8, 113);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(320, 27);
            txtResultado.TabIndex = 9;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(222, 338);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(101, 60);
            btnIgual.TabIndex = 10;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(222, 274);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(101, 58);
            btnTres.TabIndex = 11;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(329, 113);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 27);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(329, 146);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(94, 58);
            btnSoma.TabIndex = 13;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(329, 210);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(94, 58);
            btnSubtrair.TabIndex = 14;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(329, 274);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(94, 58);
            btnMultiplicar.TabIndex = 15;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(329, 338);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(94, 58);
            btnDivisao.TabIndex = 16;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // chkTemaEscuro
            // 
            chkTemaEscuro.AutoSize = true;
            chkTemaEscuro.Location = new Point(12, 12);
            chkTemaEscuro.Name = "chkTemaEscuro";
            chkTemaEscuro.Size = new Size(114, 24);
            chkTemaEscuro.TabIndex = 17;
            chkTemaEscuro.Text = "Tema Escuro";
            chkTemaEscuro.UseVisualStyleBackColor = true;
            chkTemaEscuro.CheckedChanged += chkTemaEscuro_CheckedChanged;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(8, 90);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 20);
            lblOperacao.TabIndex = 18;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(8, 341);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(101, 58);
            btnVirgula.TabIndex = 19;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 411);
            Controls.Add(btnVirgula);
            Controls.Add(lblOperacao);
            Controls.Add(chkTemaEscuro);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSoma);
            Controls.Add(btnLimpar);
            Controls.Add(btnTres);
            Controls.Add(btnIgual);
            Controls.Add(txtResultado);
            Controls.Add(btnZero);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnUm;
        private Button btnDois;
        private Button btnZero;
        private TextBox txtResultado;
        private Button btnIgual;
        private Button btnTres;
        private Button btnLimpar;
        private Button btnSoma;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDivisao;
        private CheckBox chkTemaEscuro;
        private Label lblOperacao;
        private Button btnVirgula;
    }
}
