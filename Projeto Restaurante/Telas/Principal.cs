﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Consumo abrir = new Consumo();
            abrir.ShowDialog();
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime datahora = DateTime.Now;
            Data.Text = " " +datahora.ToLocalTime();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            Timer1_Tick(e, e);
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
            Telas.Caixa abrir = new Telas.Caixa();
            abrir.ShowDialog();
        }

        private void TSBmesas_Click(object sender, EventArgs e)
        {
            Telas.Mesas abrir = new Telas.Mesas();
            abrir.ShowDialog();
        }
    }
}