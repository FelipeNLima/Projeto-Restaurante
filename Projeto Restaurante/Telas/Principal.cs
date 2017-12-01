using Projeto_Restaurante.Conexão;
using Projeto_Restaurante.Modelos;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto_Restaurante
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void TSBgarcon_Click_1(object sender, EventArgs e)
        {
            Garçom abrir = new Garçom();
            abrir.ShowDialog();
        }

        private void TSBproduto_Click_1(object sender, EventArgs e)
        {
            Produto abrir = new Produto();
            abrir.ShowDialog();
        }

        private void TSBcartão_Click(object sender, EventArgs e)
        {
            Cartão abrir = new Cartão();
            abrir.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            timer1_Tick_1(e,e);
        }

        private void TSBformapagamento_Click(object sender, EventArgs e)
        {
            Telas.FormaPagamento abrir = new Telas.FormaPagamento();
            abrir.ShowDialog();
        }

        private void TSBrestaurante_Click(object sender, EventArgs e)
        {
            Telas.Restaurante abrir = new Telas.Restaurante();
            abrir.ShowDialog();
        }

        private void TSBcardapio_Click(object sender, EventArgs e)
        {
            Telas.Cardapio abrir = new Telas.Cardapio();
            abrir.ShowDialog();
        }

        private void TSBcategoria_Click(object sender, EventArgs e)
        {
            Telas.Categoria abrir = new Telas.Categoria();
            abrir.ShowDialog();
        }

        private void TSBcaixa_Click(object sender, EventArgs e)
        {
            Modelos.ClasseCaixa caixa = new Modelos.ClasseCaixa();
            caixa.CarregarCaixa();
            if (caixa.StatusCaixa == StatusCaixa.Aberto)
            {
                Telas.Caixa abrir = new Telas.Caixa(StatusCaixa.Aberto);
                abrir.ShowDialog();
                if (abrir.FecharCaixa())
                {
                    TSBmesas.Enabled = false;
                }
            }
            else
            {
                Telas.Caixa abrir1 = new Telas.Caixa();
                abrir1.ShowDialog();
                if (abrir1.AbrirCaixa())
                    TSBmesas.Enabled = true;
            }
        }

        private void TSBmesas_Click(object sender, EventArgs e)
        {
            Telas.Mesas abrir = new Telas.Mesas();
            abrir.ShowDialog();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime datahora = DateTime.Now;
            Data.Text = "" + datahora.ToLongDateString();
            Hora.Text = "Hora: " + datahora.ToLongTimeString();
        }
    }
}
