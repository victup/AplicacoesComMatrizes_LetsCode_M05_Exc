namespace ClassificadorDeNotas
{
    partial class frmTopRanque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTopRanque));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblQtddNumeros = new System.Windows.Forms.Label();
            this.txbQtddValores = new System.Windows.Forms.TextBox();
            this.btnComecar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txbColetaValor = new System.Windows.Forms.TextBox();
            this.lblColetaValor = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblOpcaoRecomecar = new System.Windows.Forms.Label();
            this.btnRecomecar = new System.Windows.Forms.Button();
            this.lblRestantes = new System.Windows.Forms.Label();
            this.pctImageHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImageHome)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(178, 2);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(48, 57);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("VECTRO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(232, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Top Ranque";
            // 
            // lblQtddNumeros
            // 
            this.lblQtddNumeros.AutoSize = true;
            this.lblQtddNumeros.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQtddNumeros.Location = new System.Drawing.Point(182, 68);
            this.lblQtddNumeros.Name = "lblQtddNumeros";
            this.lblQtddNumeros.Size = new System.Drawing.Size(95, 30);
            this.lblQtddNumeros.TabIndex = 2;
            this.lblQtddNumeros.Text = "Quantos valores \r\ndeseja ranquear";
            // 
            // txbQtddValores
            // 
            this.txbQtddValores.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbQtddValores.Location = new System.Drawing.Point(279, 69);
            this.txbQtddValores.MaxLength = 2;
            this.txbQtddValores.Multiline = true;
            this.txbQtddValores.Name = "txbQtddValores";
            this.txbQtddValores.Size = new System.Drawing.Size(40, 30);
            this.txbQtddValores.TabIndex = 3;
            // 
            // btnComecar
            // 
            this.btnComecar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnComecar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComecar.Location = new System.Drawing.Point(325, 69);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(63, 31);
            this.btnComecar.TabIndex = 4;
            this.btnComecar.Text = "GO";
            this.btnComecar.UseVisualStyleBackColor = false;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(377, 65);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 38);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar Valor";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txbColetaValor
            // 
            this.txbColetaValor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbColetaValor.Location = new System.Drawing.Point(193, 65);
            this.txbColetaValor.MaxLength = 50;
            this.txbColetaValor.Multiline = true;
            this.txbColetaValor.Name = "txbColetaValor";
            this.txbColetaValor.Size = new System.Drawing.Size(178, 38);
            this.txbColetaValor.TabIndex = 7;
            // 
            // lblColetaValor
            // 
            this.lblColetaValor.AutoSize = true;
            this.lblColetaValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColetaValor.Location = new System.Drawing.Point(92, 68);
            this.lblColetaValor.Name = "lblColetaValor";
            this.lblColetaValor.Size = new System.Drawing.Size(95, 30);
            this.lblColetaValor.TabIndex = 6;
            this.lblColetaValor.Text = "Quantos valores \r\ndeseja ranquear";
            // 
            // lbResultado
            // 
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 15;
            this.lbResultado.Location = new System.Drawing.Point(175, 179);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(220, 214);
            this.lbResultado.TabIndex = 9;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("VECTRO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(175, 144);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(214, 32);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Top Resultados";
            this.lblResultado.Visible = false;
            // 
            // lblOpcaoRecomecar
            // 
            this.lblOpcaoRecomecar.AutoSize = true;
            this.lblOpcaoRecomecar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOpcaoRecomecar.Location = new System.Drawing.Point(205, 68);
            this.lblOpcaoRecomecar.Name = "lblOpcaoRecomecar";
            this.lblOpcaoRecomecar.Size = new System.Drawing.Size(94, 30);
            this.lblOpcaoRecomecar.TabIndex = 11;
            this.lblOpcaoRecomecar.Text = "Deseja começar \r\num novo Rank?";
            this.lblOpcaoRecomecar.Visible = false;
            // 
            // btnRecomecar
            // 
            this.btnRecomecar.BackColor = System.Drawing.Color.LightGray;
            this.btnRecomecar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRecomecar.Location = new System.Drawing.Point(305, 68);
            this.btnRecomecar.Name = "btnRecomecar";
            this.btnRecomecar.Size = new System.Drawing.Size(66, 30);
            this.btnRecomecar.TabIndex = 12;
            this.btnRecomecar.Text = "Agora";
            this.btnRecomecar.UseVisualStyleBackColor = false;
            this.btnRecomecar.Visible = false;
            this.btnRecomecar.Click += new System.EventHandler(this.btnRecomecar_Click);
            // 
            // lblRestantes
            // 
            this.lblRestantes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRestantes.Location = new System.Drawing.Point(4, 106);
            this.lblRestantes.Name = "lblRestantes";
            this.lblRestantes.Size = new System.Drawing.Size(565, 18);
            this.lblRestantes.TabIndex = 13;
            this.lblRestantes.Text = "Faltam X Valores";
            this.lblRestantes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRestantes.Visible = false;
            // 
            // pctImageHome
            // 
            this.pctImageHome.Image = ((System.Drawing.Image)(resources.GetObject("pctImageHome.Image")));
            this.pctImageHome.Location = new System.Drawing.Point(136, 127);
            this.pctImageHome.Name = "pctImageHome";
            this.pctImageHome.Size = new System.Drawing.Size(299, 302);
            this.pctImageHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImageHome.TabIndex = 14;
            this.pctImageHome.TabStop = false;
            this.pctImageHome.Visible = false;
            // 
            // frmTopRanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(571, 456);
            this.Controls.Add(this.pctImageHome);
            this.Controls.Add(this.lblRestantes);
            this.Controls.Add(this.btnRecomecar);
            this.Controls.Add(this.lblOpcaoRecomecar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txbColetaValor);
            this.Controls.Add(this.lblColetaValor);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.txbQtddValores);
            this.Controls.Add(this.lblQtddNumeros);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctLogo);
            this.MaximizeBox = false;
            this.Name = "frmTopRanque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top Ranque";
            this.Load += new System.EventHandler(this.frmTopRanque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImageHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pctLogo;
        private Label lblTitulo;
        private Label lblQtddNumeros;
        private TextBox txbQtddValores;
        private Button btnComecar;
        private Button btnRegistrar;
        private TextBox txbColetaValor;
        private Label lblColetaValor;
        private ListBox lbResultado;
        private Label lblResultado;
        private Label lblOpcaoRecomecar;
        private Button btnRecomecar;
        private Label lblRestantes;
        private PictureBox pctImageHome;
    }
}