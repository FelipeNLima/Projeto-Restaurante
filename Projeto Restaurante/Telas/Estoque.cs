using Projeto_Restaurante.Conexão;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Restaurante.Telas
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
            CarregarListViewEstoque();

        }

        List<Modelos.ClasseProduto> lista = new List<Modelos.ClasseProduto>();

        public void CarregarListViewEstoque()
        {
            Conexao obj = new Conexao();
            LVestoque.Items.Clear();
            try
            {
                string sql = $@"SELECT 
                                PRODUTO.nome_produto,
                                PRODUTO.estoque_minimo,
                                Data_entrada,
                                quantidade_entrada,
                                PRODUTO.estoque_atual
                                FROM ESTOQUE
                                INNER JOIN PRODUTO ON PRODUTO.id_produto = ESTOQUE.id_produto";
                obj.conectar();

                SqlCommand cmd = new SqlCommand(sql, obj.objCon);
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    ListViewItem nome_produto = new ListViewItem();
                    ListViewItem.ListViewSubItem esotque_minimo = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem data_entrada = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem quantidade_entrada = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem estoque_atual = new ListViewItem.ListViewSubItem();


                    nome_produto.Text = dr[0].ToString();
                    esotque_minimo.Text = dr[1].ToString();
                    if (dr[2]?.ToString() != String.Empty)
                        data_entrada.Text = DateTime.Parse(dr[2].ToString()).ToShortDateString();
                    quantidade_entrada.Text = dr[3].ToString();
                    estoque_atual.Text = dr[4].ToString();

                    nome_produto.SubItems.Add(esotque_minimo);
                    nome_produto.SubItems.Add(data_entrada);
                    nome_produto.SubItems.Add(quantidade_entrada);
                    nome_produto.SubItems.Add(estoque_atual);

                    LVestoque.Items.Add(nome_produto);

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

        private void TSBcadastrar_Click(object sender, EventArgs e)
        {
            Modelos.ClasseEstoque estoque = new Modelos.ClasseEstoque();

            estoque.Data_entrada = data.Value;
            estoque.quantidade_entrada = int.Parse(quantidade.Text);
            estoque.id_produto = lista[CBproduto.SelectedIndex];

            bool certo = estoque.CadastrarEstoque();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Estoque Salvo com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Salvar Estoque! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            lista = Modelos.ClasseProduto.CarregarProduto();

            foreach (var item in lista)
            {
                CBproduto.Items.Add(item.nome_produto);
            }
        }
    }
}
