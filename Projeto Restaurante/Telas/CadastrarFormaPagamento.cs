using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Restaurante.Telas
{
    public partial class CadastrarFormaPagamento : Form
    {
        int id;
        bool cadastrar;
        public CadastrarFormaPagamento()
        {
            InitializeComponent();
            cadastrar = true;

        }

        public CadastrarFormaPagamento(int id)
        {
            InitializeComponent();
            this.id = id;
            CarregarDados();
            cadastrar = false;
            this.Text = "Editar Forma de Pagamento";
        }

        public void cadastrarFormaPagamento()
        {
            Modelos.ClasseFormaPagamento pagamento = new Modelos.ClasseFormaPagamento();

            pagamento.tipo_pagamento = TBformaPagamento.Text;
            pagamento.apagado = false;


            bool certo = pagamento.CadastrarFormaPagamento();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Forma de Pagamento Cadastrado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Forma de Pagamento! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }

        }

        public void AtualizarFormaPagamento()
        {
            Modelos.ClasseFormaPagamento pagamento = new Modelos.ClasseFormaPagamento();

            pagamento.id_formaPagamento = id;
            pagamento.tipo_pagamento = TBformaPagamento.Text;
            pagamento.apagado = false;


            bool certo = pagamento.AtualizarFormaPagamento();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Forma de Pagamento Atualizado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar Forma de Pagamento! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }
        }

        public void CarregarDados()
        {
            Modelos.ClasseFormaPagamento pagamento = new Modelos.ClasseFormaPagamento();

            pagamento.CarregarPorID(id);
            TBformaPagamento.Text = pagamento.tipo_pagamento;

        }

        private void TSBsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void TSBcadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Verificações.VerificarCampos.Validar(Controls);
                if (VerificaFormaPagamento())
                {
                    if (cadastrar)
                    {
                        cadastrarFormaPagamento();
                    }
                    else
                    {
                        AtualizarFormaPagamento();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool VerificaFormaPagamento()
        {
            string nome = TBformaPagamento.Text;
            Modelos.ClasseFormaPagamento verifica = new Modelos.ClasseFormaPagamento();
            var tem = verifica.TemFormaPagamento(nome, id);

            if (tem)
            {

                MessageBox.Show("Nome da Forma de Pagamento ja existe! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;

        }

		private void TBformaPagamento_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaLetra(e);
		}
	}
}
