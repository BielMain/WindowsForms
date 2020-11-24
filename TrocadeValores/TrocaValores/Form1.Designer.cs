namespace TrocaValores
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
            this.txbValor = new System.Windows.Forms.TextBox();
            this.txbPorcentagem = new System.Windows.Forms.TextBox();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.rbInvestimento = new System.Windows.Forms.RadioButton();
            this.rbDivida = new System.Windows.Forms.RadioButton();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(139, 34);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 23);
            this.txbValor.TabIndex = 0;
            this.txbValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbPorcentagem
            // 
            this.txbPorcentagem.Location = new System.Drawing.Point(341, 34);
            this.txbPorcentagem.Name = "txbPorcentagem";
            this.txbPorcentagem.Size = new System.Drawing.Size(100, 23);
            this.txbPorcentagem.TabIndex = 0;
            this.txbPorcentagem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbResultado
            // 
            this.txbResultado.BackColor = System.Drawing.Color.Yellow;
            this.txbResultado.Enabled = false;
            this.txbResultado.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txbResultado.Location = new System.Drawing.Point(285, 187);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(100, 23);
            this.txbResultado.TabIndex = 0;
            this.txbResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbInvestimento
            // 
            this.rbInvestimento.AutoSize = true;
            this.rbInvestimento.Location = new System.Drawing.Point(178, 92);
            this.rbInvestimento.Name = "rbInvestimento";
            this.rbInvestimento.Size = new System.Drawing.Size(94, 19);
            this.rbInvestimento.TabIndex = 1;
            this.rbInvestimento.TabStop = true;
            this.rbInvestimento.Text = "Investimento";
            this.rbInvestimento.UseVisualStyleBackColor = true;
            this.rbInvestimento.CheckedChanged += new System.EventHandler(this.rbInvestimento_CheckedChanged);
            this.rbInvestimento.Click += new System.EventHandler(this.rbInvestimento_Click);
            // 
            // rbDivida
            // 
            this.rbDivida.AutoSize = true;
            this.rbDivida.Location = new System.Drawing.Point(297, 92);
            this.rbDivida.Name = "rbDivida";
            this.rbDivida.Size = new System.Drawing.Size(58, 19);
            this.rbDivida.TabIndex = 1;
            this.rbDivida.TabStop = true;
            this.rbDivida.Text = "Dívida";
            this.rbDivida.UseVisualStyleBackColor = true;
            this.rbDivida.CheckedChanged += new System.EventHandler(this.rbDivida_CheckedChanged);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOperacao.Location = new System.Drawing.Point(179, 195);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(60, 15);
            this.lblOperacao.TabIndex = 2;
            this.lblOperacao.Text = "Operação";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(100, 37);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor";
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(318, 37);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(17, 15);
            this.lblPorcentagem.TabIndex = 4;
            this.lblPorcentagem.Text = "%";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(232, 131);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(103, 27);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 251);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.rbDivida);
            this.Controls.Add(this.rbInvestimento);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.txbPorcentagem);
            this.Controls.Add(this.txbValor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investimento ou Dívida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.TextBox txbPorcentagem;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.RadioButton rbInvestimento;
        private System.Windows.Forms.RadioButton rbDivida;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lblOperacao;
    }
}

