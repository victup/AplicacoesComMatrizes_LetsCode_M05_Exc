namespace SeparadorImparesPares
{
    partial class frmSeparadorImparPar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblContEntradaNumeros = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lbPares = new System.Windows.Forms.ListBox();
            this.lbImpares = new System.Windows.Forms.ListBox();
            this.lbEntrada = new System.Windows.Forms.ListBox();
            this.btnRecomecar = new System.Windows.Forms.Button();
            this.lblNumerosDigitados = new System.Windows.Forms.Label();
            this.lblImpares = new System.Windows.Forms.Label();
            this.lblPares = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbNumero
            // 
            this.txbNumero.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbNumero.Location = new System.Drawing.Point(214, 80);
            this.txbNumero.Multiline = true;
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(138, 38);
            this.txbNumero.TabIndex = 0;
            this.txbNumero.TextChanged += new System.EventHandler(this.txbNumero_TextChanged);
            // 
            // lblContEntradaNumeros
            // 
            this.lblContEntradaNumeros.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContEntradaNumeros.Location = new System.Drawing.Point(12, 37);
            this.lblContEntradaNumeros.Name = "lblContEntradaNumeros";
            this.lblContEntradaNumeros.Size = new System.Drawing.Size(629, 20);
            this.lblContEntradaNumeros.TabIndex = 2;
            this.lblContEntradaNumeros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(358, 80);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(81, 38);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar Numero";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lbPares
            // 
            this.lbPares.FormattingEnabled = true;
            this.lbPares.ItemHeight = 15;
            this.lbPares.Location = new System.Drawing.Point(430, 185);
            this.lbPares.Name = "lbPares";
            this.lbPares.Size = new System.Drawing.Size(176, 154);
            this.lbPares.TabIndex = 12;
            // 
            // lbImpares
            // 
            this.lbImpares.FormattingEnabled = true;
            this.lbImpares.ItemHeight = 15;
            this.lbImpares.Location = new System.Drawing.Point(238, 185);
            this.lbImpares.Name = "lbImpares";
            this.lbImpares.Size = new System.Drawing.Size(178, 154);
            this.lbImpares.TabIndex = 11;
            // 
            // lbEntrada
            // 
            this.lbEntrada.FormattingEnabled = true;
            this.lbEntrada.ItemHeight = 15;
            this.lbEntrada.Location = new System.Drawing.Point(42, 185);
            this.lbEntrada.Name = "lbEntrada";
            this.lbEntrada.Size = new System.Drawing.Size(178, 154);
            this.lbEntrada.TabIndex = 10;
            // 
            // btnRecomecar
            // 
            this.btnRecomecar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRecomecar.Location = new System.Drawing.Point(267, 358);
            this.btnRecomecar.Name = "btnRecomecar";
            this.btnRecomecar.Size = new System.Drawing.Size(96, 39);
            this.btnRecomecar.TabIndex = 13;
            this.btnRecomecar.Text = "Recomeçar";
            this.btnRecomecar.UseVisualStyleBackColor = false;
            this.btnRecomecar.Visible = false;
            this.btnRecomecar.Click += new System.EventHandler(this.btnRecomecar_Click);
            // 
            // lblNumerosDigitados
            // 
            this.lblNumerosDigitados.AutoSize = true;
            this.lblNumerosDigitados.Location = new System.Drawing.Point(42, 167);
            this.lblNumerosDigitados.Name = "lblNumerosDigitados";
            this.lblNumerosDigitados.Size = new System.Drawing.Size(148, 15);
            this.lblNumerosDigitados.TabIndex = 14;
            this.lblNumerosDigitados.Text = "Números que você digitou";
            // 
            // lblImpares
            // 
            this.lblImpares.AutoSize = true;
            this.lblImpares.Location = new System.Drawing.Point(238, 167);
            this.lblImpares.Name = "lblImpares";
            this.lblImpares.Size = new System.Drawing.Size(49, 15);
            this.lblImpares.TabIndex = 15;
            this.lblImpares.Text = "Impares";
            // 
            // lblPares
            // 
            this.lblPares.AutoSize = true;
            this.lblPares.Location = new System.Drawing.Point(430, 167);
            this.lblPares.Name = "lblPares";
            this.lblPares.Size = new System.Drawing.Size(35, 15);
            this.lblPares.TabIndex = 16;
            this.lblPares.Text = "Pares";
            // 
            // frmSeparadorImparPar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.lblPares);
            this.Controls.Add(this.lblImpares);
            this.Controls.Add(this.lblNumerosDigitados);
            this.Controls.Add(this.btnRecomecar);
            this.Controls.Add(this.lbPares);
            this.Controls.Add(this.lbImpares);
            this.Controls.Add(this.lbEntrada);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblContEntradaNumeros);
            this.Controls.Add(this.txbNumero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSeparadorImparPar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Separador Impar-Par";
            this.Load += new System.EventHandler(this.frmSeparadorImparPar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbNumero;
        private Label lblContEntradaNumeros;
        private Button btnRegistrar;
        private ListBox lbPares;
        private ListBox lbImpares;
        private ListBox lbEntrada;
        private Button btnRecomecar;
        private Label lblNumerosDigitados;
        private Label lblImpares;
        private Label lblPares;
    }
}