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

namespace LinhasVersusColunas
{
    public partial class frmLinhasVersusColunas : Form
    {
        int[,] Matriz { get; set; }
        
        public frmLinhasVersusColunas()
        {
            InitializeComponent();
        }
        int qtddLinhas;
        int qtddColunas;
        private void btnGerarTabela_Click(object sender, EventArgs e)
        {
            lblResultado.Text = String.Empty;

            pctLogoGrande.Visible = false;

            qtddLinhas = validaNumero(txbLinhas.Text);
            qtddColunas = validaNumero(txbColunas.Text);

            txbColunas.Text = String.Empty;
            txbLinhas.Text = String.Empty;

            Matriz = new int[qtddLinhas, qtddColunas];

            for (int linha = 0; linha < Matriz.GetLength(0); linha++)
            {



                for (int coluna = 0; coluna < Matriz.GetLength(1); coluna++)
                {
                    Matriz[linha, 0] = linha + 1;
                    lblResultado.Text += $"L{Matriz[linha, 0].ToString()}";

                    Matriz[linha, coluna] = coluna + 1;

                    lblResultado.Text += $"C{Matriz[linha, coluna].ToString()}         ";

                  


                }

                lblResultado.Text += $" \n";


            }
        }

        private int validaNumero(string valor)
        {
            var entradaValida = new Regex(@"[0-9]");

            int numero = 0;

            if (entradaValida.IsMatch(valor))
            {
                numero = int.Parse(valor);

            }

            return numero;
        }
    }
}
