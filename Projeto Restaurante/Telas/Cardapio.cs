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

	public partial class Cardapio : Form
    {
        public Cardapio()
        {
            InitializeComponent();
			CarregarListView();
        }

		public void CarregarListView()
		{
			Conexao obj = new Conexao();
			listViewcardapio.Items.Clear();
			try
			{
				string sql = $@"SELECT 
                                id_cardapio,
                                nome_item,   
                                preco_item,
                                CATEGORIACARDAPIO.descricao										
                                FROM CARDAPIO  
                                INNER JOIN CATEGORIACARDAPIO ON CATEGORIACARDAPIO.id_categoriacardapio = CARDAPIO.id_categoriacardapio
                                WHERE CARDAPIO.apagado = 0 AND nome_item LIKE '%{TBpesquisa.Text}%'";
				obj.conectar();

				SqlCommand cmd = new SqlCommand(sql, obj.objCon);
				SqlDataReader dr = cmd.ExecuteReader();


				while (dr.Read())
				{
					ListViewItem id = new ListViewItem();
					ListViewItem.ListViewSubItem nomeitem = new ListViewItem.ListViewSubItem();
					ListViewItem.ListViewSubItem precoitem = new ListViewItem.ListViewSubItem();
					ListViewItem.ListViewSubItem descricao = new ListViewItem.ListViewSubItem();


					id.Text = dr[0].ToString();
					nomeitem.Text = dr[1].ToString();
					precoitem.Text = dr[2].ToString();
					descricao.Text = dr[3].ToString();


					id.SubItems.Add(nomeitem);
					id.SubItems.Add(precoitem);
					id.SubItems.Add(descricao);

					listViewcardapio.Items.Add(id);

				}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally { obj.desconectar(); }



		}

		private void TSBsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void TSBadicionar_Click(object sender, EventArgs e)
        {
            Telas.CadastrarCardapio abrir = new CadastrarCardapio();
            abrir.ShowDialog();
			CarregarListView();
		}

		private void TSBeditar_Click(object sender, EventArgs e)
		{
			if (listViewcardapio.SelectedItems.Count > 0)
			{
				CadastrarCardapio Abrir = new CadastrarCardapio(int.Parse(listViewcardapio.SelectedItems[0].Text));
				Abrir.ShowDialog();
				CarregarListView();
			}
			else
			{
				MessageBox.Show("Linha Não Selecionada !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void TSBdeletar_Click(object sender, EventArgs e)
		{
			if (listViewcardapio.SelectedItems.Count > 0)
			{
				var opcao = MessageBox.Show("Deseja Realmente apagar esse Prato!!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (opcao == DialogResult.Yes)
				{
					var id = int.Parse(listViewcardapio.SelectedItems[0].Text);
					Modelos.ClasseCardapio chamar = new Modelos.ClasseCardapio();
					chamar.CarregarPorId(id);
					chamar.DeletarCardapio();
					CarregarListView();

				}

			}
			else
			{
				MessageBox.Show("Prato não selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Cardapio_Load(object sender, EventArgs e)
		{
			CarregarListView();
		}

		private void BTpesquisa_Click(object sender, EventArgs e)
		{
            try
            {
                Verificações.VerificarCampos.Validar(Controls);
                if (TBpesquisa.Text == string.Empty)
                {
                    MessageBox.Show("Escreva o nome do Prato para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    CarregarListView();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
		}

		private void TBpesquisa_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaLetra(e);
		}
	}
}
