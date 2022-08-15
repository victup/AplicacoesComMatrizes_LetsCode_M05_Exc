namespace JogoDaVelha
{
    public partial class frmJogoDaVelha : Form
    {
        string[,] Tabuleiro { get; set; } = new string[3, 3];
        public string[] Jogadores { get; set; } = new string[4];
        
        string simboloQueJoga = "";


        public frmJogoDaVelha(string[] jogadores)
        {
            InitializeComponent();

            this.Jogadores = jogadores;
        }
 

        private void frmJogoDaVelha_Load(object sender, EventArgs e)
        {
            this.simboloQueJoga = Jogadores[1];

            lblJogadorQueJoga.Text = dadosDoJogadorDaVez(Jogadores);

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.TabStop = false;
                   
                }
            }
        }

       

        private void btnL1C1_Click(object sender, EventArgs e)
        {
            btnL1C1.Enabled = false;
            btnL1C1.Text = simboloQueJoga;
            Tabuleiro[0, 0] = simboloQueJoga;

            anunciaGanhador(verificaGanhador(), dadosDoJogadorDaVez(Jogadores));
            reiniciaPartida(Tabuleiro, verificaGanhador());


            this.simboloQueJoga = trocaJogador(simboloQueJoga);
            lblJogadorQueJoga.Text = dadosDoJogadorDaVez(Jogadores);
        }


        private void btnL1C2_Click(object sender, EventArgs e)
        {
            btnL1C2.Enabled = false;
            btnL1C2.Text = simboloQueJoga;
            Tabuleiro[0, 1] = simboloQueJoga;

            anunciaGanhador(verificaGanhador(), dadosDoJogadorDaVez(Jogadores));
            reiniciaPartida(Tabuleiro, verificaGanhador());

            this.simboloQueJoga = trocaJogador(simboloQueJoga);

            lblJogadorQueJoga.Text = dadosDoJogadorDaVez(Jogadores);
        }

        private void btnL1C3_Click(object sender, EventArgs e)
        {

            btnL1C3.Enabled = false;
            btnL1C3.Text = simboloQueJoga;
            Tabuleiro[0, 2] = simboloQueJoga;

            anunciaGanhador(verificaGanhador(), dadosDoJogadorDaVez(Jogadores));
            reiniciaPartida(Tabuleiro, verificaGanhador());

            this.simboloQueJoga = trocaJogador(simboloQueJoga);

            lblJogadorQueJoga.Text = dadosDoJogadorDaVez(Jogadores);
        }

        private void btnL2C1_Click(object sender, EventArgs e)
        {
            btnL2C1.Enabled = false;
            btnL2C1.Text = simboloQueJoga;
            Tabuleiro[1, 0] = simboloQueJoga;

            anunciaGanhador(verificaGanhador(), dadosDoJogadorDaVez(Jogadores));
            reiniciaPartida(Tabuleiro, verificaGanhador());

            this.simboloQueJoga = trocaJogador(simboloQueJoga);
            lblJogadorQueJoga.Text = dadosDoJogadorDaVez(Jogadores);
        }

        private void btnL2C2_Click(object sender, EventArgs e)
        {
            btnL2C2.Enabled = false;
            btnL2C2.Text = simboloQueJoga;
            Tabuleiro[1, 1] = simboloQueJoga;

            anunciaGanhador(verificaGanhador(), dadosDoJogadorDaVez(Jogadores));
            reiniciaPartida(Tabuleiro, verificaGanhador());

            this.simboloQueJoga = trocaJogador(simboloQueJoga);
            lblJogadorQueJoga.Text = dadosDoJogadorDaVez(Jogadores);
        }

        private void btnL2C3_Click(object sender, EventArgs e)
        {    
            btnL2C3.Enabled = false;
            btnL2C3.Text = simboloQueJoga;
            Tabuleiro[1, 2] = simboloQueJoga;

            anunciaGanhador(verificaGanhador(), dadosDoJogadorDaVez(Jogadores));
            reiniciaPartida(Tabuleiro, verificaGanhador());

            this.simboloQueJoga = trocaJogador(simboloQueJoga);
            lblJogadorQueJoga.Text = dadosDoJogadorDaVez(Jogadores);
        }

        private void btnL3C1_Click(object sender, EventArgs e)
        {
            btnL3C1.Enabled = false;
            btnL3C1.Text = simboloQueJoga;
            Tabuleiro[2, 0] = simboloQueJoga;

            anunciaGanhador(verificaGanhador(), dadosDoJogadorDaVez(Jogadores));
            reiniciaPartida(Tabuleiro, verificaGanhador());

            this.simboloQueJoga = trocaJogador(simboloQueJoga);
            lblJogadorQueJoga.Text = dadosDoJogadorDaVez(Jogadores);
        }

        private void btnL3C2_Click(object sender, EventArgs e)
        {
           btnL3C2.Enabled = false;
            btnL3C2.Text = simboloQueJoga;
            Tabuleiro[2, 1] = simboloQueJoga;

            anunciaGanhador(verificaGanhador(), dadosDoJogadorDaVez(Jogadores));
            reiniciaPartida(Tabuleiro, verificaGanhador());

            this.simboloQueJoga = trocaJogador(simboloQueJoga);
            lblJogadorQueJoga.Text = dadosDoJogadorDaVez(Jogadores);
        }

        private void btnL3C3_Click(object sender, EventArgs e)
        {

            btnL3C3.Enabled = false;
            btnL3C3.Text = simboloQueJoga;
            Tabuleiro[2, 2] = simboloQueJoga;

            anunciaGanhador(verificaGanhador(), dadosDoJogadorDaVez(Jogadores));
            reiniciaPartida(Tabuleiro, verificaGanhador());

            this.simboloQueJoga = trocaJogador(simboloQueJoga);
            lblJogadorQueJoga.Text = dadosDoJogadorDaVez(Jogadores);
        }

        private string dadosDoJogadorDaVez(string[] dadosDosJogadores)
        {
            string info;

            if (simboloQueJoga == dadosDosJogadores[1])
            {
                info = $"Jogador: {dadosDosJogadores[0]}  \n Simbolo: {dadosDosJogadores[1]}";

                return info;
            }
            else
            {
                info = $"Jogador: {dadosDosJogadores[2]}  \n Simbolo: {dadosDosJogadores[3]}";
                return info;
            }
        }

        private string trocaJogador(string simbolo)
        {
            string novoJogador = "";

            if (simbolo == "X")
            {
                novoJogador = "O";
            }
            else
            {
                novoJogador = "X";
            }

            return novoJogador;
        }

        private bool verificaGanhador()
        {
         
            bool houveGanhador = false;

            if (((Tabuleiro[0, 0] == "X") && (Tabuleiro[0, 1] == "X") && (Tabuleiro[0, 2] == "X")) || ((Tabuleiro[0, 0] == "O") && Tabuleiro[0, 1] == "O") && (Tabuleiro[0, 2] == "O"))
            {
                houveGanhador = true;
            }
            else
                if (((Tabuleiro[1, 0] == "X") && (Tabuleiro[1, 1] == "X") && (Tabuleiro[1, 2] == "X")) || ((Tabuleiro[1, 0] == "O") && Tabuleiro[1, 1] == "O") && (Tabuleiro[1, 2] == "O"))
            {
                houveGanhador = true;
            }
            else
                if (((Tabuleiro[2, 0] == "X") && (Tabuleiro[2, 1] == "X") && (Tabuleiro[2, 2] == "X")) || ((Tabuleiro[2, 0] == "O") && Tabuleiro[2, 1] == "O") && (Tabuleiro[2, 2] == "O"))
            {
                houveGanhador = true;
            }


            else
                if (((Tabuleiro[0, 0] == "X") && (Tabuleiro[1, 0] == "X") && (Tabuleiro[2, 0] == "X")) || ((Tabuleiro[0, 0] == "O") && Tabuleiro[1, 0] == "O") && (Tabuleiro[2, 0] == "O"))
            {
                houveGanhador = true;
            }
            else
                if (((Tabuleiro[0, 1] == "X") && (Tabuleiro[1, 1] == "X") && (Tabuleiro[2, 1] == "X")) || ((Tabuleiro[0, 1] == "O") && Tabuleiro[1, 1] == "O") && (Tabuleiro[2, 1] == "O"))
            {
                houveGanhador = true;
            }
            else
                if (((Tabuleiro[0, 2] == "X") && (Tabuleiro[1, 2] == "X") && (Tabuleiro[2, 2] == "X")) || ((Tabuleiro[0, 2] == "O") && Tabuleiro[1, 2] == "O") && (Tabuleiro[2, 2] == "O"))
            {
                houveGanhador = true;
            }


            else
                if (((Tabuleiro[0, 0] == "X") && (Tabuleiro[1, 1] == "X") && (Tabuleiro[2, 2] == "X")) || ((Tabuleiro[0, 0] == "O") && Tabuleiro[1, 1] == "O") && (Tabuleiro[2, 2] == "O"))
            {
                houveGanhador = true;
            }
            else
                if (((Tabuleiro[0, 2] == "X") && (Tabuleiro[1, 1] == "X") && (Tabuleiro[2, 0] == "X")) || ((Tabuleiro[0, 2] == "O") && Tabuleiro[1, 1] == "O") && (Tabuleiro[2, 0] == "O"))
            {
                houveGanhador = true;
            }

            return houveGanhador;
        }

        private void anunciaGanhador(bool houveGanhador, string jogador)
        {
            if( houveGanhador == true)
            {
                MessageBox.Show($"Tivemos um ganhador! Parabéns! \n {jogador}");
                this.Close();
            }
        }
        
        private void reiniciaPartida( string[,] tabuleiro, bool houveGanhador)
        {
            if(houveGanhador == true)
            {
                Array.Clear(tabuleiro, 0, tabuleiro.Length);
                resetaBotoes();
            }
        }

        private void resetaBotoes()
        {
            foreach (Control control in this.Controls)
            {
                if ((control is Button) && (control.Enabled == false))
                {
                    control.Enabled = true;
                    control.Text = String.Empty;

                }
            }
        }
    }
}