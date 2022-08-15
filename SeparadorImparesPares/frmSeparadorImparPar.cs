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

namespace SeparadorImparesPares
{
    public partial class frmSeparadorImparPar : Form
    {

        private decimal Numero { get; set; }
        private int[] Numeros { get; set; } = new int[10];
        private int[] NumerosPares { get; set; } = new int[10];
        private int[] NumerosImpares { get; set; } = new int[10];

        public frmSeparadorImparPar()
        {
            InitializeComponent();
        }

        private void txbNumero_TextChanged(object sender, EventArgs e)
        {
            

        }

        int i = 0;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(validaNumero(txbNumero.Text) && i < 10)
            {
                lblContEntradaNumeros.Text = $"Restam {9 - i} a serem preenchidos";
                recebeEntrada();
                i++;

                if(i == 10)
                {
                    configuraTelaResultado();

                    imprimeResultado();                }
            }              
            

        }


        private void btnRecomecar_Click(object sender, EventArgs e)
        {

            configuraInicio();

        }
        private void frmSeparadorImparPar_Load(object sender, EventArgs e)
        {
            configuraInicio();

            if (validaNumero(txbNumero.Text) && i < 10)
            {
                recebeEntrada();
                i++;
            }

        }


        private void configuraTelaResultado()
        {
            lblContEntradaNumeros.Visible = false;
            txbNumero.Enabled = false;
            btnRegistrar.Enabled = false;
            btnRecomecar.Visible = true;

            lblNumerosDigitados.Visible = true;
            lbEntrada.Visible = true;
            lblImpares.Visible = true;
            lbImpares.Visible = true;
            lblPares.Visible = true;
            lbPares.Visible = true;
        }
        private void configuraInicio()
        {
            lbEntrada.Items.Clear();
            lbImpares.Items.Clear();
            lbPares.Items.Clear();
            Array.Clear(Numeros);
            Array.Clear(NumerosPares);
            Array.Clear(NumerosImpares);
            i = 0;
            lblContEntradaNumeros.Text = $"Restam {10 - i} a serem preenchidos";
            lblContEntradaNumeros.Visible = true;
            txbNumero.Enabled = true;
            btnRegistrar.Enabled = true;
            btnRecomecar.Visible = false;

            lblNumerosDigitados.Visible = false;
            lbEntrada.Visible = false;
            lblImpares.Visible = false;
            lbImpares.Visible = false;
            lblPares.Visible = false;
            lbPares.Visible = false;
        }

        private bool validaNumero(string entrada)
        {
            var entradaValida = new Regex("[0-9]");
            if (entradaValida.IsMatch(entrada))
            {
                return true;

            }
            else
            {

                txbNumero.Text = String.Empty;
                lblContEntradaNumeros.Text = "Apenas números maiores que 0 são validos";
                return false;
            }
        }
        private void recebeEntrada()
        {

            this.Numeros[i] = int.Parse(txbNumero.Text.Replace(".", "").Replace(",","")) ;
            txbNumero.Text = string.Empty;

        }

        private void imprimeResultado()
        {
            Array.Sort(Numeros);
            Array.Sort(NumerosPares);
            Array.Sort(NumerosImpares);

            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] % 2 == 0)
                {
                    NumerosPares[i] = Numeros[i];
                }
                else
                {
                    NumerosImpares[i] = Numeros[i];
                }
            }


            foreach (int n in Numeros)
            {
                if (n > 0)
                {
                    lbEntrada.Items.Add(n);
                }
            }

            foreach (int n in NumerosImpares)
            {
                if (n > 0)
                {
                    lbImpares.Items.Add(n);
                }

            }

            foreach (int n in NumerosPares)
            {
                if (n > 0)
                {
                    lbPares.Items.Add(n);
                }

            }
        }


    }

 
}
