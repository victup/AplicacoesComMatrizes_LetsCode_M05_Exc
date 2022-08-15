namespace Menu_de_Projetos
{
    partial class frmHomeProjetos
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
            this.menuHome = new System.Windows.Forms.MenuStrip();
            this.menuOpcProjetos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpcProjetosImparesPares = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpcProjetosRankDeNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpcProjetosLinhasColunas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpcProjetosJogoDaVelha = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpcAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpcAjudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHome
            // 
            this.menuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpcProjetos,
            this.menuOpcAjuda});
            this.menuHome.Location = new System.Drawing.Point(0, 0);
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(552, 24);
            this.menuHome.TabIndex = 0;
            this.menuHome.Text = "menuStrip1";
            // 
            // menuOpcProjetos
            // 
            this.menuOpcProjetos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpcProjetosImparesPares,
            this.menuOpcProjetosRankDeNotas,
            this.menuOpcProjetosLinhasColunas,
            this.menuOpcProjetosJogoDaVelha});
            this.menuOpcProjetos.Name = "menuOpcProjetos";
            this.menuOpcProjetos.Size = new System.Drawing.Size(62, 20);
            this.menuOpcProjetos.Text = "Projetos";
            // 
            // menuOpcProjetosImparesPares
            // 
            this.menuOpcProjetosImparesPares.Name = "menuOpcProjetosImparesPares";
            this.menuOpcProjetosImparesPares.Size = new System.Drawing.Size(228, 22);
            this.menuOpcProjetosImparesPares.Text = "Separador de Impares e Pares";
            this.menuOpcProjetosImparesPares.Click += new System.EventHandler(this.menuOpcProjetosImparesPares_Click);
            // 
            // menuOpcProjetosRankDeNotas
            // 
            this.menuOpcProjetosRankDeNotas.Name = "menuOpcProjetosRankDeNotas";
            this.menuOpcProjetosRankDeNotas.Size = new System.Drawing.Size(228, 22);
            this.menuOpcProjetosRankDeNotas.Text = "Rank de Notas";
            this.menuOpcProjetosRankDeNotas.Click += new System.EventHandler(this.menuOpcProjetosRankDeNotas_Click);
            // 
            // menuOpcProjetosLinhasColunas
            // 
            this.menuOpcProjetosLinhasColunas.Name = "menuOpcProjetosLinhasColunas";
            this.menuOpcProjetosLinhasColunas.Size = new System.Drawing.Size(228, 22);
            this.menuOpcProjetosLinhasColunas.Text = "Linhas x Colunas";
            this.menuOpcProjetosLinhasColunas.Click += new System.EventHandler(this.menuOpcProjetosLinhasColunas_Click);
            // 
            // menuOpcProjetosJogoDaVelha
            // 
            this.menuOpcProjetosJogoDaVelha.Name = "menuOpcProjetosJogoDaVelha";
            this.menuOpcProjetosJogoDaVelha.Size = new System.Drawing.Size(228, 22);
            this.menuOpcProjetosJogoDaVelha.Text = "Jogo da Velha";
            this.menuOpcProjetosJogoDaVelha.Click += new System.EventHandler(this.menuOpcProjetosJogoDaVelha_Click);
            // 
            // menuOpcAjuda
            // 
            this.menuOpcAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpcAjudaSobre});
            this.menuOpcAjuda.Name = "menuOpcAjuda";
            this.menuOpcAjuda.Size = new System.Drawing.Size(50, 20);
            this.menuOpcAjuda.Text = "Ajuda";
            // 
            // menuOpcAjudaSobre
            // 
            this.menuOpcAjudaSobre.Name = "menuOpcAjudaSobre";
            this.menuOpcAjudaSobre.Size = new System.Drawing.Size(180, 22);
            this.menuOpcAjudaSobre.Text = "Sobre";
            this.menuOpcAjudaSobre.Click += new System.EventHandler(this.menuOpcAjudaSobre_Click);
            // 
            // frmHomeProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.menuHome);
            this.MainMenuStrip = this.menuHome;
            this.MaximizeBox = false;
            this.Name = "frmHomeProjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Projetos de Matrizes";
            this.menuHome.ResumeLayout(false);
            this.menuHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuHome;
        private ToolStripMenuItem menuOpcProjetos;
        private ToolStripMenuItem menuOpcAjuda;
        private ToolStripMenuItem menuOpcAjudaSobre;
        private ToolStripMenuItem menuOpcProjetosImparesPares;
        private ToolStripMenuItem menuOpcProjetosRankDeNotas;
        private ToolStripMenuItem menuOpcProjetosLinhasColunas;
        private ToolStripMenuItem menuOpcProjetosJogoDaVelha;
    }
}