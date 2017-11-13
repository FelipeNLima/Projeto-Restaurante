using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Restaurante
{
    public partial class CadastroProduto : Form
    {
        bool cadastrar;
        int id;
        List<Modelos.ClasseCategoria_Produto> lista = new List<Modelos.ClasseCategoria_Produto>();
        public CadastroProduto()
        {
            InitializeComponent();
            cadastrar = true;

        }

        public CadastroProduto(int id)
        {
            InitializeComponent();
            this.id = id;
            cadastrar = false;
            this.Text = "Editar Produto";
        }

        private void TSBsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void TSBadicionar_Click(object sender, EventArgs e)
        {
            if (cadastrar)
            {
                cadastrarProduto();

            }
            else
            {
                AtualizarProduto();
            }
        }

        public void cadastrarProduto()
        {
            Modelos.ClasseProduto produto = new Modelos.ClasseProduto();

            produto.nome_produto = TBnomeproduto.Text;
            produto.preco_custo = float.Parse(TBprecocusto.Text);
            produto.categoria = lista[CBcategoria.SelectedIndex];
            produto.estoque_atual = int.Parse(TBestoqueatual.Text);
            produto.estoque_minimo = int.Parse(TBestoqueminimo.Text);
            produto.apagado = false;



            bool certo = produto.Cadastrarproduto();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Produto cadastrada com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Produto! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }
        }

        public void AtualizarProduto()
        {
            Modelos.ClasseProduto produto = new Modelos.ClasseProduto();

            produto.id_produto = id;
            produto.nome_produto = TBnomeproduto.Text;
            produto.preco_custo = float.Parse(TBprecocusto.Text);
            produto.categoria = lista[CBcategoria.SelectedIndex];
            produto.estoque_atual = int.Parse(TBestoqueatual.Text);
            produto.estoque_minimo = int.Parse(TBestoqueminimo.Text);




            bool certo = produto.Atualizarproduto();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Produto atualizado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar Produto! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }
        }

        public void CarregarDados()
        {
            Modelos.ClasseProduto produto = new Modelos.ClasseProduto();

            produto.CarregarPorId(id);
            TBnomeproduto.Text = produto.nome_produto.ToString();
            TBprecocusto.Text = produto.preco_custo.ToString();
            CBcategoria.SelectedItem = Modelos.ClasseCategoria_Produto.CarregarCategoriaProduto();
            TBestoqueatual.Text = produto.estoque_atual.ToString();
            TBestoqueminimo.Text = produto.estoque_minimo.ToString();

        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            lista = Modelos.ClasseCategoria_Produto.CarregarCategoriaProduto();

            foreach (var item in lista)
            {
                CBcategoria.Items.Add(item.descricao);
            }

            // VERIFICA SE EH ATUALZAR
            if (!cadastrar)
                CarregarDados();
        }

		private void TBnomeproduto_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaLetra(e);
		}

		private void TBprecocusto_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaNumero(e);
		}

		private void TBestoqueatual_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaNumero(e);
		}

		private void TBestoqueminimo_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaNumero(e);
		}
	}
}
