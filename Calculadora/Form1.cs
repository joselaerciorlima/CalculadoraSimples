using System;
using System.Windows.Forms;

namespace Calculadora
{
   public partial class Form1 : Form
   {
      bool primeiroNumero = true;
      double valorAnterior, valorAtual;
      public Form1()
      {
         InitializeComponent();
      }

      private void btnZero_Click(object sender, EventArgs e)
      {
         Input("0");
      }

      private void btnUm_Click(object sender, EventArgs e)
      {
         Input("1"); ;
      }

      private void btnDois_Click(object sender, EventArgs e)
      {
         Input("2"); ;
      }

      private void btnTres_Click(object sender, EventArgs e)
      {
         Input("3"); ;
      }

      private void btnQuatro_Click(object sender, EventArgs e)
      {
         Input("4"); ;
      }

      private void btnCinco_Click(object sender, EventArgs e)
      {
         Input("5"); ;
      }

      private void btnSeis_Click(object sender, EventArgs e)
      {
         Input("6"); ;
      }

      private void btnSete_Click(object sender, EventArgs e)
      {
         Input("7"); ;
      }

      private void btnOito_Click(object sender, EventArgs e)
      {
         Input("8"); ;
      }

      private void btnNove_Click(object sender, EventArgs e)
      {
         Input("9"); ;
      }

      private void btnLimpar_Click(object sender, EventArgs e)
      {
         txtDisplay.Text = "0";
         primeiroNumero = true;
      }

      private void btnApagar_Click(object sender, EventArgs e)
      {
         if (txtDisplay.Text.Length > 0)
         {
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            if (txtDisplay.Text.Length == 0)
            {
               txtDisplay.Text = "0";
               primeiroNumero = true;
            }
         }
      }

      private void Input(string valor)
      {
         if (primeiroNumero)
         {
            txtDisplay.Text = "";
            primeiroNumero = false;
         }
         txtDisplay.Text += valor;
      }
   }
}
