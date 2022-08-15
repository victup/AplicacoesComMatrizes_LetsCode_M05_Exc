namespace JogoDaVelha
{
    partial class frmHomeJogoDaVelha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeJogoDaVelha));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnComecar = new System.Windows.Forms.Button();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.txbJogador1 = new System.Windows.Forms.TextBox();
            this.txbJogador2 = new System.Windows.Forms.TextBox();
            this.opcXjogador1 = new System.Windows.Forms.Button();
            this.opcCirculoJogador1 = new System.Windows.Forms.Button();
            this.opcXjogador2 = new System.Windows.Forms.Button();
            this.opcCirculoJogador2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(169, 55);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(134, 122);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitulo.Location = new System.Drawing.Point(159, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(162, 27);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Vai dar velha";
            // 
            // btnComecar
            // 
            this.btnComecar.BackColor = System.Drawing.Color.DarkRed;
            this.btnComecar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComecar.Location = new System.Drawing.Point(182, 204);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(116, 42);
            this.btnComecar.TabIndex = 2;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = false;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJogador1.Location = new System.Drawing.Point(64, 166);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(88, 21);
            this.lblJogador1.TabIndex = 3;
            this.lblJogador1.Text = "Jogador 1";
            this.lblJogador1.Visible = false;
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJogador2.Location = new System.Drawing.Point(64, 213);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(88, 21);
            this.lblJogador2.TabIndex = 4;
            this.lblJogador2.Text = "Jogador 2";
            this.lblJogador2.Visible = false;
            // 
            // txbJogador1
            // 
            this.txbJogador1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbJogador1.Location = new System.Drawing.Point(158, 154);
            this.txbJogador1.Multiline = true;
            this.txbJogador1.Name = "txbJogador1";
            this.txbJogador1.Size = new System.Drawing.Size(150, 42);
            this.txbJogador1.TabIndex = 5;
            this.txbJogador1.Visible = false;
            // 
            // txbJogador2
            // 
            this.txbJogador2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbJogador2.Location = new System.Drawing.Point(158, 204);
            this.txbJogador2.Multiline = true;
            this.txbJogador2.Name = "txbJogador2";
            this.txbJogador2.Size = new System.Drawing.Size(150, 42);
            this.txbJogador2.TabIndex = 6;
            this.txbJogador2.Visible = false;
            // 
            // opcXjogador1
            // 
            this.opcXjogador1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.opcXjogador1.Location = new System.Drawing.Point(314, 154);
            this.opcXjogador1.Name = "opcXjogador1";
            this.opcXjogador1.Size = new System.Drawing.Size(49, 42);
            this.opcXjogador1.TabIndex = 7;
            this.opcXjogador1.Text = "x";
            this.opcXjogador1.UseVisualStyleBackColor = true;
            this.opcXjogador1.Visible = false;
            this.opcXjogador1.Click += new System.EventHandler(this.opcXjogador1_Click);
            // 
            // opcCirculoJogador1
            // 
            this.opcCirculoJogador1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.opcCirculoJogador1.Location = new System.Drawing.Point(367, 154);
            this.opcCirculoJogador1.Name = "opcCirculoJogador1";
            this.opcCirculoJogador1.Size = new System.Drawing.Size(49, 42);
            this.opcCirculoJogador1.TabIndex = 8;
            this.opcCirculoJogador1.Text = "o";
            this.opcCirculoJogador1.UseVisualStyleBackColor = true;
            this.opcCirculoJogador1.Visible = false;
            this.opcCirculoJogador1.Click += new System.EventHandler(this.opcCirculoJogador1_Click);
            // 
            // opcXjogador2
            // 
            this.opcXjogador2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.opcXjogador2.Location = new System.Drawing.Point(314, 204);
            this.opcXjogador2.Name = "opcXjogador2";
            this.opcXjogador2.Size = new System.Drawing.Size(49, 42);
            this.opcXjogador2.TabIndex = 9;
            this.opcXjogador2.Text = "x";
            this.opcXjogador2.UseVisualStyleBackColor = true;
            this.opcXjogador2.Visible = false;
            this.opcXjogador2.Click += new System.EventHandler(this.opcXjogador2_Click);
            // 
            // opcCirculoJogador2
            // 
            this.opcCirculoJogador2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.opcCirculoJogador2.Location = new System.Drawing.Point(367, 204);
            this.opcCirculoJogador2.Name = "opcCirculoJogador2";
            this.opcCirculoJogador2.Size = new System.Drawing.Size(49, 42);
            this.opcCirculoJogador2.TabIndex = 10;
            this.opcCirculoJogador2.Text = "o";
            this.opcCirculoJogador2.UseVisualStyleBackColor = true;
            this.opcCirculoJogador2.Visible = false;
            this.opcCirculoJogador2.Click += new System.EventHandler(this.opcCirculoJogador2_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.opcCirculoJogador2);
            this.Controls.Add(this.opcXjogador2);
            this.Controls.Add(this.opcCirculoJogador1);
            this.Controls.Add(this.opcXjogador1);
            this.Controls.Add(this.txbJogador2);
            this.Controls.Add(this.txbJogador1);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.lblJogador1);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctLogo);
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Vai Dar Velha";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pctLogo;
        private Label lblTitulo;
        protected internal Button btnComecar;
        private Label lblJogador1;
        private Label lblJogador2;
        private TextBox txbJogador1;
        private TextBox txbJogador2;
        private Button opcXjogador1;
        private Button opcCirculoJogador1;
        private Button opcXjogador2;
        private Button opcCirculoJogador2;
    }
}