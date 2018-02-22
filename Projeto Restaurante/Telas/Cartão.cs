using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Restaurante
{
    using Conexão;
    public partial class Cartão : Form
    {
        public Cartão()
        {
            InitializeComponent();
            CarregarListView();
        }

        public void CarregarListView()
        {
            Conexao obj = new Conexao();
            LVbandeira.Items.Clear();
            try
            {
                string sql = $@"SELECT
                                id_bandeira,
                                nome_bandeira,   
                                FORMA_PAGAMENTO.tipo_pagamento 
                                FROM BANDEIRA_CARTAO 
								INNER JOIN FORMA_PAGAMENTO ON FORMA_PAGAMENTO.id_formaPagamento = BANDEIRA_CARTAO.id_formaPagamento 
                                WHERE BANDEIRA_CARTAO.apagado = 0 AND nome_bandeira LIKE '%{TBpesquisa.Text}%'";
                obj.conectar();

                SqlCommand cmd = new SqlCommand(sql, obj.objCon);
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    ListViewItem id = new ListViewItem();
                    ListViewItem.ListViewSubItem nome = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem formaPagamento = new ListViewItem.ListViewSubItem();


                    id.Text = dr[0].ToString();
                    nome.Text = dr[1].ToString();
                    formaPagamento.Text = dr[2].ToString();

                    id.SubItems.Add(nome);
                    id.SubItems.Add(formaPagamento);

                    LVbandeira.Items.Add(id);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { obj.desconectar(); }



        }

        private void TSBadicionar_Click(object sender, EventArgs e)
        {
            CadastrarBandeira abrir = new CadastrarBandeira();
            abrir.ShowDialog();
            CarregarListView();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void TSBatualizar_Click(object sender, EventArgs e)
        {
            if (LVbandeira.SelectedItems.Count > 0)
            {
                
                CadastrarBandeira teste = new CadastrarBandeira(int.Parse(LVbandeira.SelectedItems[0].Text));
                teste.ShowDialog();
                CarregarListView();
            }
            else
            {
                MessageBox.Show("Linha Não Selecionada !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TSBdeletar_Click(object sender, EventArgs e)
        {
            if (LVbandeira.SelectedItems.Count > 0)
            {
                var opcao = MessageBox.Show("Deseja Realmente apagar Bandeira do Cartão!!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    var id = int.Parse(LVbandeira.SelectedItems[0].Text);
                    Modelos.ClasseBandeira chamar = new Modelos.ClasseBandeira();
                    chamar.CarregarPorID(id);
                    chamar.DeletarBandeira();
                    CarregarListView();

                }

            }
            else
            {
                MessageBox.Show("Bandeira não selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTpesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                Verificações.VerificarCampos.Validar(Controls);
                if (TBpesquisa.Text == string.Empty)
                {
                    MessageBox.Show("Escreva o nome da Bandeira de Cartão para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    CarregarListView();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cartão_Load(object sender, EventArgs e)
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
