using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassificadorDeNotas
{
    public partial class frmTopRanque : Form
    {
        private int qtddValores = 0;

        double[] Valores { get; set; }

        double[] Rank { get; set; }

        int i = 0;

        public frmTopRanque()
        {
            InitializeComponent();
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {

            this.qtddValores = (int)validaNumero(txbQtddValores.Text);

            txbQtddValores.Clear();

            Valores = new double[this.qtddValores];

            lblQtddNumeros.Visible = false;
            txbQtddValores.Visible = false;
            btnComecar.Visible = false;

            pctImageHome.Visible = false;

            lblColetaValor.Visible = true;
            txbColetaValor.Visible = true;
            btnRegistrar.Visible = true;

        }


        private void frmTopRanque_Load(object sender, EventArgs e)
        {
            lblColetaValor.Visible = false;
            txbColetaValor.Visible = false;
            btnRegistrar.Visible = false;
            lbResultado.Visible = false;
            pctImageHome.Visible = true;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            lblRestantes.Visible = true;

            if (i < this.qtddValores)
            {

                

                string entrada = txbColetaValor.Text.ToString();
                entrada = entrada.Replace('.', ',');
                Valores[i] = validaNumero(entrada);
                txbColetaValor.Text = String.Empty;
                lbResultado.Visible = true;
                lbResultado.Items.Add(Valores[i].ToString());

                i++;

                lblRestantes.Text = $"Faltam {qtddValores - i} valores a serem preenchidos";

                if (i == this.qtddValores)
                {
                    lblRestantes.Visible = false;

                    lbResultado.Items.Clear();
                    lblColetaValor.Visible = false;
                    txbColetaValor.Visible = false;
                    btnRegistrar.Visible = false;
                    lblResultado.Visible = true;
                    
                    lblOpcaoRecomecar.Visible = true;
                    btnRecomecar.Visible = true;

                    Rank = new double[qtddValores];
                    Valores.CopyTo(Rank, 0);
                    Array.Sort(Rank);
                    Array.Reverse(Rank);


                    int rank = 1;
                    double ultimoValor = 0;
                    foreach (var valor in Rank)
                    {
                        if (ultimoValor > valor)
                        {
                            rank++;
                        }

                        lbResultado.Items.Add($"Rank {rank}º: {valor}");


                        ultimoValor = valor;

                    }
                  
                }
            }

        }

        private double validaNumero(string valor)
        {
            var entradaValida = new Regex(@"(\d{1,3}(\.\d{3})*|\d+)");

            double numero = 2.6 ;

            if (entradaValida.IsMatch(valor))
            {
                numero = double.Parse(valor);

            }

            return numero;
        }

        private void btnRecomecar_Click(object sender, EventArgs e)
        {
            btnRecomecar.Visible = false;
            lblOpcaoRecomecar.Visible = false;
            lbResultado.Visible = false;
            lblResultado.Visible = false;

            pctImageHome.Visible = true;

            lblQtddNumeros.Visible = true;
            txbQtddValores.Visible = true;
            btnComecar.Visible = true;

            lbResultado.Items.Clear();

            Array.Clear(Valores);
            Array.Clear(Rank);

            i = 0;
          

            

        }
    }

    

}
