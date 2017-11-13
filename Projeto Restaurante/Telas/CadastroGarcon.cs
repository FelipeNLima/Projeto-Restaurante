using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Restaurante
{
    using Conexão;

    public partial class CadastroGarcon : Form
    {
        bool cadastrar;
        int id;
        public CadastroGarcon()
        {
            InitializeComponent();
            cadastrar = true;

        }

		// METODO PARA ATUALIZAR 
        public CadastroGarcon(int id)
        {
            InitializeComponent();
            this.id = id;
            CarregarDados();
            cadastrar = false;
            this.Text = "Editar Garçom";

        }

		// METODOS 
        public void cadastrarGarcom()
        {
            Modelos.ClasseGarcom garcom = new Modelos.ClasseGarcom();

            garcom.nome_garcom = TBnomegarcon.Text;
            garcom.codigo = Convert.ToInt32(TBcodigo.Text);
            garcom.taxa_serviço = 0;
            garcom.apagado = false;


            bool certo = garcom.Cadastrargarcom();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Garçom cadastrada com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Garçom! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }

        }

        public void AtualizarGarcom()
        {
            Modelos.ClasseGarcom garcom = new Modelos.ClasseGarcom();

            garcom.id_garcom = id;
            garcom.nome_garcom = TBnomegarcon.Text;
            garcom.codigo = Convert.ToInt32(TBcodigo.Text);
            garcom.apagado = false;


            bool certo = garcom.Atualizargarcom();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Garçom atualizado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar Garçom! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }
        }

        public void CarregarDados()
        {
            Modelos.ClasseGarcom dados = new Modelos.ClasseGarcom();
            dados.CarregarPorId(id);
            TBnomegarcon.Text = dados.nome_garcom;
            TBcodigo.Text = dados.codigo.ToString();
        }

		public bool VerificaGarcom()
        {
            int codigo = int.Parse(TBcodigo.Text);
            Modelos.ClasseGarcom verifica = new Modelos.ClasseGarcom();
            var tem = verifica.TemGarcom(codigo, id);

            if (tem)
            {

                MessageBox.Show("Codigo do Garçom ja existe! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;

        }

        private void TSBsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void TSBcadastrar_Click(object sender, EventArgs e)
        {
            if (VerificaGarcom())
            {

                if (cadastrar)
                {
                    cadastrarGarcom();
                }
                else
                {
                    AtualizarGarcom();
                }
            }
        }

		//VERIFICANDO ENTRADA
		private void TBnomegarcon_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaLetra(e);
		}

		private void TBcodigo_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaNumero(e);
		}
	}
}
