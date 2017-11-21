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
	using Conexão;
	using System.Data.SqlClient;

	public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();

			if(radioButton1.Checked)
			{
				CarregarListViewCardapio();
			}
			else
			{
				CarregarListViewProduto();
			}
		}

		public void CarregarListViewCardapio()
		{
			Conexao obj = new Conexao();
			LVcategoria.Items.Clear();
			try
				{
					string sql = $@"SELECT 
                                id_categoriacardapio,
                                descricao
                                FROM CATEGORIACARDAPIO  
                                WHERE apagado = 0 AND descricao LIKE '%{TBpesquisa.Text}%'";
					obj.conectar();

					SqlCommand cmd = new SqlCommand(sql, obj.objCon);
					SqlDataReader dr = cmd.ExecuteReader();


					while (dr.Read())
					{
						ListViewItem id = new ListViewItem();
						ListViewItem.ListViewSubItem descricao = new ListViewItem.ListViewSubItem();
						


						id.Text = dr[0].ToString();
						descricao.Text = dr[1].ToString();
						
						id.SubItems.Add(descricao);
						
						LVcategoria.Items.Add(id);

					}


				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally { obj.desconectar(); }

		}

		public void CarregarListViewProduto()
		{
			Conexao obj = new Conexao();
			LVcategoria.Items.Clear();
			try
				{
					string sql = $@"SELECT 
                                id_categoriaproduto,
                                descricao
                                FROM CATEGORIAPRODUTO  
                                WHERE apagado = 0 AND descricao LIKE '%{TBpesquisa.Text}%'";
					obj.conectar();

					SqlCommand cmd = new SqlCommand(sql, obj.objCon);
					SqlDataReader dr = cmd.ExecuteReader();


					while (dr.Read())
					{
						ListViewItem id = new ListViewItem();
						ListViewItem.ListViewSubItem descricao = new ListViewItem.ListViewSubItem();



						id.Text = dr[0].ToString();
						descricao.Text = dr[1].ToString();

						id.SubItems.Add(descricao);

						LVcategoria.Items.Add(id);

					}


				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally { obj.desconectar(); }

		}

		private void TSBcadastrar_Click(object sender, EventArgs e)
        {
			Telas.CadastrarCategorias abrir = new CadastrarCategorias(radioButton1.Checked);
            abrir.ShowDialog();
            if(radioButton1.Checked)
            {
                CarregarListViewCardapio();
            }
            else
            {
                CarregarListViewProduto();
            }
		}

        private void TSBsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

		private void TSBeditar_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				if (LVcategoria.SelectedItems.Count > 0)
				{

					CadastrarCategorias teste = new CadastrarCategorias(int.Parse(LVcategoria.SelectedItems[0].Text), radioButton1.Checked);
					teste.ShowDialog();
					CarregarListViewCardapio();
				}
				else
				{
					MessageBox.Show("Linha Não Selecionada !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				if (LVcategoria.SelectedItems.Count > 0)
				{

					CadastrarCategorias teste = new CadastrarCategorias(int.Parse(LVcategoria.SelectedItems[0].Text),radioButton1.Checked);
					teste.ShowDialog();
					CarregarListViewProduto();
				}
				else
				{
					MessageBox.Show("Linha Não Selecionada !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void TSBdeletar_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				if (LVcategoria.SelectedItems.Count > 0)
				{
					var opcao = MessageBox.Show("Deseja Realmente apagar Categoria!!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (opcao == DialogResult.Yes)
					{
						var id = int.Parse(LVcategoria.SelectedItems[0].Text);
						Modelos.ClasseCategoria_Cardapio chamar = new Modelos.ClasseCategoria_Cardapio();
						chamar.CarregarCardapioID(id);
						chamar.DeletarCategoriaCardapio();
						CarregarListViewCardapio();

					}

				}
				else
				{
					MessageBox.Show("Categoria não selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				if (LVcategoria.SelectedItems.Count > 0)
				{
					var opcao = MessageBox.Show("Deseja Realmente apagar categoria!!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (opcao == DialogResult.Yes)
					{
						var id = int.Parse(LVcategoria.SelectedItems[0].Text);
						Modelos.ClasseCategoria_Produto chamar = new Modelos.ClasseCategoria_Produto();
						chamar.CarregarProdutoID(id);
						chamar.DeletarCategoriaProduto();
						CarregarListViewProduto();

					}

				}
				else
				{
					MessageBox.Show("Categoria não selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void BTpesquisa_Click(object sender, EventArgs e)
		{
            try
            {
                Verificações.VerificarCampos.Validar(Controls);

                if (radioButton1.Checked)
                {
                    if (TBpesquisa.Text == string.Empty)
                    {
                        MessageBox.Show("Escreva o nome da Categoria para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        CarregarListViewCardapio();
                    }
                }
                else
                {
                    if (TBpesquisa.Text == string.Empty)
                    {
                        MessageBox.Show("Escreva o nome da Categoria para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        CarregarListViewProduto();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private void radioButton1_Click(object sender, EventArgs e)
		{
			CarregarListViewCardapio();
		}

		private void radioButton2_Click(object sender, EventArgs e)
		{
			CarregarListViewProduto();
		}

		private void TBpesquisa_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaLetra(e);
		}

        private void Categoria_Load(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                CarregarListViewCardapio();
            }
            else
            {
                CarregarListViewProduto();
            }
        }
    }
}
