using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Projeto_Restaurante
{
    using Conexão;
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
            CarregarListView();
        }

        private void TSBadicionar_Click(object sender, EventArgs e)
        {
            CadastroProduto abrir = new CadastroProduto();
            abrir.ShowDialog();
            CarregarListView();
           
        }

        private void TSBsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void TSBatualizar_Click(object sender, EventArgs e)
        {
            if (listViewProduto.SelectedItems.Count > 0)
            {
       
                CadastroProduto Abrir = new CadastroProduto(int.Parse(listViewProduto.SelectedItems[0].Text));
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
            if (listViewProduto.SelectedItems.Count > 0)
            {
                var opcao = MessageBox.Show("Deseja Realmente apagar esse Produto!!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    var id = int.Parse(listViewProduto.SelectedItems[0].Text);
                    Modelos.ClasseProduto chamar = new Modelos.ClasseProduto();
                    chamar.CarregarPorId(id);
                    chamar.Deletarproduto();
                    CarregarListView();

                }

            }
            else
            {
                MessageBox.Show("Produto não selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTpesquisa_Click(object sender, EventArgs e)
        {
            if (TBpesquisa.Text == string.Empty)
            {
                MessageBox.Show("Escreva o nome do Produto para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                CarregarListView();
            }
        }

        public void CarregarListView()
        {
            Conexao obj = new Conexao();
            listViewProduto.Items.Clear();
            try
            {
                string sql = $@"SELECT 
                                id_produto,
                                nome_produto,   
                                preco_custo,
                                CATEGORIAPRODUTO.descricao,		
                                estoque_atual,				
                                estoque_minimo								
                                FROM PRODUTO  
                                INNER JOIN CATEGORIAPRODUTO ON CATEGORIAPRODUTO.id_categoriaproduto = PRODUTO.id_categoriaproduto
                                WHERE PRODUTO.apagado = 0 AND nome_produto LIKE '%{TBpesquisa.Text}%'";
                obj.conectar();

                SqlCommand cmd = new SqlCommand(sql, obj.objCon);
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    ListViewItem id = new ListViewItem();
                    ListViewItem.ListViewSubItem nome = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem precocusto = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem descricao = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem estoqueatual = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem estoqueminimo = new ListViewItem.ListViewSubItem();


                    id.Text = dr[0].ToString();
                    nome.Text = dr[1].ToString();
                    precocusto.Text = dr[2].ToString();
                    descricao.Text = dr[3].ToString();
                    estoqueatual.Text = dr[4].ToString();
                    estoqueminimo.Text = dr[5].ToString();


                    id.SubItems.Add(nome);
                    id.SubItems.Add(precocusto);
                    id.SubItems.Add(descricao);
                    id.SubItems.Add(estoqueatual);
                    id.SubItems.Add(estoqueminimo);
                    

                    listViewProduto.Items.Add(id);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { obj.desconectar(); }



        }

        private void Produto_Load(object sender, EventArgs e)
        {
            CarregarListView();
        }

		private void TBpesquisa_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaLetra(e);
		}
	}
}
