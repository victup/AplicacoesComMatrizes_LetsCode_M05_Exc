namespace LinhasVersusColunas
{
    partial class frmLinhasVersusColunas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLinhasVersusColunas));
            this.pctLogoGrande = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLinhas = new System.Windows.Forms.Label();
            this.lblColunas = new System.Windows.Forms.Label();
            this.txbLinhas = new System.Windows.Forms.TextBox();
            this.txbColunas = new System.Windows.Forms.TextBox();
            this.btnGerarTabela = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoGrande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogoGrande
            // 
            this.pctLogoGrande.Image = ((System.Drawing.Image)(resources.GetObject("pctLogoGrande.Image")));
            this.pctLogoGrande.Location = new System.Drawing.Point(239, 206);
            this.pctLogoGrande.Name = "pctLogoGrande";
            this.pctLogoGrande.Size = new System.Drawing.Size(299, 258);
            this.pctLogoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogoGrande.TabIndex = 0;
            this.pctLogoGrande.TabStop = false;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(229, 26);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(28, 27);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Scorpion", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(260, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(268, 22);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Linhas x Colunas";
            // 
            // lblLinhas
            // 
            this.lblLinhas.AutoSize = true;
            this.lblLinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLinhas.Location = new System.Drawing.Point(251, 89);
            this.lblLinhas.Name = "lblLinhas";
            this.lblLinhas.Size = new System.Drawing.Size(191, 16);
            this.lblLinhas.TabIndex = 3;
            this.lblLinhas.Text = "Digite o número de Linhas:";
            // 
            // lblColunas
            // 
            this.lblColunas.AutoSize = true;
            this.lblColunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColunas.Location = new System.Drawing.Point(251, 124);
            this.lblColunas.Name = "lblColunas";
            this.lblColunas.Size = new System.Drawing.Size(198, 16);
            this.lblColunas.TabIndex = 4;
            this.lblColunas.Text = "Digite o número de Colunas";
            // 
            // txbLinhas
            // 
            this.txbLinhas.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbLinhas.Location = new System.Drawing.Point(455, 79);
            this.txbLinhas.MaxLength = 2;
            this.txbLinhas.Multiline = true;
            this.txbLinhas.Name = "txbLinhas";
            this.txbLinhas.Size = new System.Drawing.Size(51, 29);
            this.txbLinhas.TabIndex = 5;
            // 
            // txbColunas
            // 
            this.txbColunas.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbColunas.Location = new System.Drawing.Point(455, 114);
            this.txbColunas.MaxLength = 2;
            this.txbColunas.Multiline = true;
            this.txbColunas.Name = "txbColunas";
            this.txbColunas.Size = new System.Drawing.Size(51, 29);
            this.txbColunas.TabIndex = 6;
            // 
            // btnGerarTabela
            // 
            this.btnGerarTabela.BackColor = System.Drawing.Color.Black;
            this.btnGerarTabela.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGerarTabela.Location = new System.Drawing.Point(308, 160);
            this.btnGerarTabela.Name = "btnGerarTabela";
            this.btnGerarTabela.Size = new System.Drawing.Size(141, 33);
            this.btnGerarTabela.TabIndex = 7;
            this.btnGerarTabela.Text = "Gerar Tabela";
            this.btnGerarTabela.UseVisualStyleBackColor = false;
            this.btnGerarTabela.Click += new System.EventHandler(this.btnGerarTabela_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(12, 196);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(752, 368);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmLinhasVersusColuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(776, 573);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnGerarTabela);
            this.Controls.Add(this.txbColunas);
            this.Controls.Add(this.txbLinhas);
            this.Controls.Add(this.lblColunas);
            this.Controls.Add(this.lblLinhas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.pctLogoGrande);
            this.MaximizeBox = false;
            this.Name = "frmLinhasVersusColuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linhas Versus Colunas";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogoGrande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pctLogoGrande;
        private PictureBox pctLogo;
        private Label lblTitulo;
        private Label lblLinhas;
        private Label lblColunas;
        private TextBox txbLinhas;
        private TextBox txbColunas;
        private Button btnGerarTabela;
        private Label lblResultado;
    }
}