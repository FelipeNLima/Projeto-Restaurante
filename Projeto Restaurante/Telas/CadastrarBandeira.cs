using Projeto_Restaurante.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Restaurante
{
    public partial class CadastrarBandeira : Form
    {
        bool cadastrar;
        int id;

        List<ClasseFormaPagamento> listaformapagamento = new List<ClasseFormaPagamento>();

        public CadastrarBandeira()
        {
            InitializeComponent();
            cadastrar = true;
        }

        public CadastrarBandeira(int id)
        {
            InitializeComponent();
            this.id = id;
            CarregarDados();
            cadastrar = false;
            this.Text = "Editar Bandeira";
        }

        public void cadastrarBandeira()
        {
            Modelos.ClasseBandeira bandeira = new Modelos.ClasseBandeira();

            bandeira.nome_bandeira = TBnomeBandeira.Text;
            bandeira.taxa = float.Parse(TBtaxa.Text);
            bandeira.apagado = false;
            bandeira.formapagamento = listaformapagamento[CBformaPagamento.SelectedIndex];


            bool certo = bandeira.CadastrarBandeira();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Bandeira do Cartão Cadastrada com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Bandeira do Cartão! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }

        }

        public void AtualizarBandeira()
        {
            Modelos.ClasseBandeira bandeira = new Modelos.ClasseBandeira();

            bandeira.id_bandeira = id;
            bandeira.nome_bandeira = TBnomeBandeira.Text;
            bandeira.taxa = float.Parse(TBtaxa.Text);
            bandeira.apagado = false;
            bandeira.formapagamento = listaformapagamento[CBformaPagamento.SelectedIndex];


            bool certo = bandeira.AtualizarBandeira();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Bandeira do Cartão Atualizado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar Bandeira do Cartão! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }
        }

        public void CarregarDados()
        {
            Modelos.ClasseBandeira bandeira = new Modelos.ClasseBandeira();
            bandeira.CarregarPorID(id);
            TBnomeBandeira.Text = bandeira.nome_bandeira;
            TBtaxa.Text = bandeira.taxa.ToString();
            CBformaPagamento.SelectedItem = ClasseFormaPagamento.CarregarFormadePagamento();

        }

        private void TSBsair_Click(object sender, EventArgs e)
        {
            Hide();

        }

        private void TSBcadastrar_Click(object sender, EventArgs e)
        {
            if (VerificaBandeira())
            {

                if (cadastrar)
                {
                    cadastrarBandeira();
                }
                else
                {
                    AtualizarBandeira();
                }
            }
        }

        public bool VerificaBandeira()
        {
            string nome = (TBnomeBandeira.Text);
            Modelos.ClasseBandeira verifica = new Modelos.ClasseBandeira();
            var tem = verifica.TemBandeira(nome, id);

            if (tem)
            {

                MessageBox.Show("Nome da Bandeira ja existe! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;

        }

		private void TBnomeBandeira_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaLetra(e);
		}

		private void TBtaxa_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaNumero(e);
		}

        private void CadastrarBandeira_Load(object sender, EventArgs e)
        {
            listaformapagamento = ClasseFormaPagamento.CarregarFormadePagamento();

            foreach (var item in listaformapagamento)
            {
                CBformaPagamento.Items.Add(item.tipo_pagamento);
            }
        }
    }
}
