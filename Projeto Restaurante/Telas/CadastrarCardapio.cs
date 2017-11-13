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
	
    public partial class CadastrarCardapio : Form
    {
		bool cadastrar;
		int id;

		List<Modelos.ClasseCategoria_Cardapio> lista = new List<Modelos.ClasseCategoria_Cardapio>();

		public CadastrarCardapio()
        {
            InitializeComponent();
			cadastrar = true; 
        }

		public CadastrarCardapio(int id)
		{
			InitializeComponent();
			this.id = id;
			cadastrar = false;
			this.Text = "Editar Cardápio";
		}

		public void cadastrarCardapio()
		{
			Modelos.ClasseCardapio cardapio = new Modelos.ClasseCardapio();

			cardapio.nome_item = TBnomeprato.Text;
			cardapio.preco_item = float.Parse(TBvalorprato.Text);
			cardapio.categoria = lista[CBcategoriaprato.SelectedIndex];
			cardapio.apagado = false;


			bool certo = cardapio.CadastrarCardapio();
			try
			{
				if (certo)
				{
					MessageBox.Show("Cardápio Cadastrado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else
				{
					MessageBox.Show("Erro ao Cadastrar Cardápio! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			catch (Exception erro)
			{
				MessageBox.Show(erro + "Erro Ocorrido");
			}

		}

		public void AtualizarCardapio()
		{
			Modelos.ClasseCardapio cardapio = new Modelos.ClasseCardapio();

			cardapio.id_cardapio = id;
			cardapio.nome_item = TBnomeprato.Text;
			cardapio.preco_item = float.Parse(TBvalorprato.Text);
			cardapio.categoria = lista[CBcategoriaprato.SelectedIndex];
			cardapio.apagado = false;


			bool certo = cardapio.AtualizarCardapio();
			try
			{
				if (certo)
				{
					MessageBox.Show("Cardápio Atualizado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Close();
				}
				else
				{
					MessageBox.Show("Erro ao Atualizar Cardápio! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			catch (Exception erro)
			{
				MessageBox.Show(erro + "Erro Ocorrido");
			}
		}

		public void CarregarDados()
		{
			Modelos.ClasseCardapio cardapio = new Modelos.ClasseCardapio();

			cardapio.CarregarPorId(id);
			TBnomeprato.Text = cardapio.nome_item;
			TBvalorprato.Text = cardapio.preco_item.ToString();
			CBcategoriaprato.SelectedItem = Modelos.ClasseCategoria_Cardapio.CarregarCategoriaCardapio();
		}

		private void TSBsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

		private void CadastrarCardapio_Load(object sender, EventArgs e)
		{
			lista = Modelos.ClasseCategoria_Cardapio.CarregarCategoriaCardapio();

			foreach (var item in lista)
			{
				CBcategoriaprato.Items.Add(item.descricao);
			}

			// VERIFICA SE EH ATUALZAR
			if (!cadastrar)
				CarregarDados();
		}

		private void TSBcadastrar_Click(object sender, EventArgs e)
		{
			if (cadastrar)
			{
				cadastrarCardapio();

			}
			else
			{
				AtualizarCardapio();
			}
		}

		private void TBnomeprato_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaLetra(e);
		}

		private void TBvalorprato_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaNumero(e);
		}
	}
}
