using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class frmHomeJogoDaVelha : Form
    {

        private string[] Jogadores { get; set; } = new string[4];

        public frmHomeJogoDaVelha()
        {
            InitializeComponent();
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            pctLogo.Visible = false;
            lblTitulo.Visible = false;
            btnComecar.Visible = false;

            lblJogador1.Visible = true;
            lblJogador2.Visible = true;
            txbJogador1.Visible = true;
            txbJogador2.Visible = true;
            opcCirculoJogador1.Visible = true;
            opcCirculoJogador2.Visible = true;
            opcXjogador1.Visible = true;
            opcXjogador2.Visible = true;


        }

        private void opcXjogador1_Click(object sender, EventArgs e)
        {
            opcCirculoJogador1.Enabled = false;
            opcXjogador2.Enabled = false;
            configuracaoDePartida();

            opcCirculoJogador1.Enabled = true;
            opcXjogador2.Enabled = true;
        }

        private void opcCirculoJogador1_Click(object sender, EventArgs e)
        {
            opcXjogador1.Enabled = false;
            opcCirculoJogador2.Enabled = false;
            configuracaoDePartida();

            opcXjogador1.Enabled = true;
            opcCirculoJogador2.Enabled = true;
        }

        private void opcXjogador2_Click(object sender, EventArgs e)
        {
            opcCirculoJogador2.Enabled = false;
            opcXjogador1.Enabled = false;
            configuracaoDePartida();

            opcCirculoJogador2.Enabled = true;
            opcXjogador1.Enabled = true;
        }

        private void opcCirculoJogador2_Click(object sender, EventArgs e)
        {
            opcXjogador2.Enabled = false;
            opcCirculoJogador1.Enabled = false;
            configuracaoDePartida();

            opcXjogador2.Enabled = true;
            opcCirculoJogador1.Enabled = true;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void configuracaoDePartida()
        {
           Jogadores[0] = txbJogador1.Text;
           Jogadores[2] = txbJogador2.Text;
            

            if ((opcXjogador1.Enabled == true && opcCirculoJogador2.Enabled == true))
            {
                Jogadores[1] = "X";
                Jogadores[3] = "O";
            }
            else
                if((opcXjogador2.Enabled == true && opcCirculoJogador1.Enabled == true))
            {
                Jogadores[1] = "O";
                Jogadores[3] = "X";
            }

            if((Jogadores[0] != "") && (Jogadores[1] != "") && (Jogadores[2] != "") && (Jogadores[3] != "") )
            {
                iniciaPartida();
            }

        }

        private void iniciaPartida()
        {
            this.Hide();
            frmJogoDaVelha frmJogoDaVelha = new frmJogoDaVelha(Jogadores);
            frmJogoDaVelha.ShowDialog();
            this.Show();

            pctLogo.Visible = true;
            lblTitulo.Visible = true;
            btnComecar.Visible = true;

            txbJogador1.Clear();
            txbJogador2.Clear();

            lblJogador1.Visible = false;
            lblJogador2.Visible = false;
            txbJogador1.Visible = false;
            txbJogador2.Visible = false;
            opcCirculoJogador1.Visible = false;
            opcCirculoJogador2.Visible = false;
            opcXjogador1.Visible = false;
            opcXjogador2.Visible = false;

            Array.Clear(Jogadores, 0, Jogadores.Length);

        }

       
    }
}
