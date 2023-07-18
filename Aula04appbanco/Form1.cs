using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04appbanco
{
    public partial class Form1 : Form
    {
        // variavei globais
        List<string> extratos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            double saldo = double.Parse(lblSaldo.Text.Replace("R$", ""));
            double soma;
           
            if (lblOperação.Text == "Saque")
            {
                soma = saldo - valor;
                extratos.Add("Saque no valor de R$ " + valor);
            }
            else
            {
                 soma = valor + saldo;
                extratos.Add("Depósito no valor de R$ " + valor);
            }
            lblSaldo.Text = "R$ " + soma;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            btnDepositar.BackColor = Color.MediumPurple;
            btnDepositar.ForeColor = Color.Black;
            btnSacar.BackColor = Color.LightBlue;
            btnSacar.ForeColor = Color.Black;
            lblOperação.Text = "Depósito";
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            btnSacar.BackColor = Color.MediumPurple;
            btnSacar.ForeColor = Color.Black;
            btnDepositar.BackColor = Color.LightBlue;
            btnDepositar.ForeColor = Color.Black;
            lblOperação.Text = "Saque";
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            Form2 telaExtrato = new Form2();
            telaExtrato.extratos = extratos;
            telaExtrato.Show();
        }
    }
}
