﻿using ClassificadorDeNotas;
using JogoDaVelha;
using LinhasVersusColunas;
using SeparadorImparesPares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Menu_de_Projetos
{
    public partial class frmHomeProjetos : Form
    {
        public frmHomeProjetos()
        {
            InitializeComponent();
        }

        private void menuOpcProjetosImparesPares_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSeparadorImparPar frmSeparadorImparPar = new frmSeparadorImparPar();
            frmSeparadorImparPar.ShowDialog();
            this.Show();
        }

        private void menuOpcProjetosRankDeNotas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTopRanque frmTopRanque = new frmTopRanque(); 
            frmTopRanque.ShowDialog();
            this.Show();
        }

        private void menuOpcProjetosLinhasColunas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLinhasVersusColunas frmLinhasVersusColunas = new frmLinhasVersusColunas();
            frmLinhasVersusColunas.ShowDialog();
            this.Show();
        }

        private void menuOpcProjetosJogoDaVelha_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomeJogoDaVelha frmJogoDaVelha = new frmHomeJogoDaVelha();
            frmJogoDaVelha.ShowDialog();
            this.Show();
        }

        private void menuOpcAjudaSobre_Click(object sender, EventArgs e)
        {
            frmSobreProjetos frmSobreProjetos = new frmSobreProjetos();
            frmSobreProjetos.ShowDialog();  
        }
    }
}
