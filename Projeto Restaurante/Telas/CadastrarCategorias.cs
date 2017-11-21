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
    public partial class CadastrarCategorias : Form
    {
		bool cadastrar;
		int id;
		bool cardapio;
		public CadastrarCategorias(bool CARDAPIO)
        {
            InitializeComponent();
			cadastrar = true;
			this.cardapio = CARDAPIO;
        }

		public CadastrarCategorias(int id, bool cardapio)
		{
			InitializeComponent();
			this.id = id;
			cadastrar = false;
			this.cardapio = cardapio;

			if(cardapio)
			{
				CarregarDadosCardapio();
			}
			else
			{
				CarregarDadosProduto();
			}
			this.Text = "Editar Categoria";
			
		}


		public void cadastrarCategoriaCardapio()
		{
			Modelos.ClasseCategoria_Cardapio cardapio = new Modelos.ClasseCategoria_Cardapio();

			cardapio.descricao = TBdescricao.Text;
			cardapio.apagado = false;


			bool certo = cardapio.CadastrarCategoriaCardapio();
			try
			{
				if (certo)
				{
					MessageBox.Show("Categoria do Cardápio Cadastrado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else
				{
					MessageBox.Show("Erro ao Cadastrar Categoria do Cardápio! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			catch (Exception erro)
			{
				MessageBox.Show(erro + "Erro Ocorrido");
			}

		}

		public void AtualizarCategoriaCardapio()
		{
			Modelos.ClasseCategoria_Cardapio cardapio = new Modelos.ClasseCategoria_Cardapio();

			cardapio.id_categoriacardapio = id;
			cardapio.descricao = TBdescricao.Text;
			cardapio.apagado = false;


			bool certo = cardapio.AtualizarCategoriaCardapio();
			try
			{
				if (certo)
				{
					MessageBox.Show("Categoria do Cardápio Atualizado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else
				{
					MessageBox.Show("Erro ao Atualizar Categoria do Cardápio! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			catch (Exception erro)
			{
				MessageBox.Show(erro + "Erro Ocorrido");
			}
		}

		public void CarregarDadosCardapio()
		{
			Modelos.ClasseCategoria_Cardapio cardapio = new Modelos.ClasseCategoria_Cardapio();
			cardapio.CarregarCardapioID(id);
			TBdescricao.Text = cardapio.descricao;
		}

		public void cadastrarCategoriaProduto()
		{
			Modelos.ClasseCategoria_Produto produto = new Modelos.ClasseCategoria_Produto();

			produto.descricao = TBdescricao.Text;
			produto.apagado = false;


			bool certo = produto.CadastrarCategoriaProduto();
			try
			{
				if (certo)
				{
					MessageBox.Show("Categoria do Produto Cadastrado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else
				{
					MessageBox.Show("Erro ao Cadastrar Categoria do Produto! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			catch (Exception erro)
			{
				MessageBox.Show(erro + "Erro Ocorrido");
			}

		}

		public void AtualizarCategoriaProduto()
		{
			Modelos.ClasseCategoria_Produto produto = new Modelos.ClasseCategoria_Produto();

			produto.id_categoriaproduto = id;
			produto.descricao = TBdescricao.Text;
			produto.apagado = false;


			bool certo = produto.AtualizarCategoriaProduto();
			try
			{
				if (certo)
				{
					MessageBox.Show("Categoria do Produto Atualizado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else
				{
					MessageBox.Show("Erro ao Atualizar Categoria do Produto! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			catch (Exception erro)
			{
				MessageBox.Show(erro + "Erro Ocorrido");
			}
		}

		public void CarregarDadosProduto()
		{
			Modelos.ClasseCategoria_Produto produto = new Modelos.ClasseCategoria_Produto();
			produto.CarregarProdutoID(id);
			TBdescricao.Text = produto.descricao;
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
                if (cardapio)
                {

                    if (cadastrar)
                    {

                        cadastrarCategoriaCardapio();
                    }
                    else
                    {

                        AtualizarCategoriaCardapio();

                    }
                }
                else
                {
                    if (cadastrar)
                    {

                        cadastrarCategoriaProduto();
                    }
                    else
                    {
                        AtualizarCategoriaProduto();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private void TBdescricao_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaLetra(e);
		}
	}
}
