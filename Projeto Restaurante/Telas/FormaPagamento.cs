using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Restaurante.Telas
{
    using Conexão;
    public partial class FormaPagamento : Form
    {
        public FormaPagamento()
        {
            InitializeComponent();
        }

        private void TSBadicionar_Click(object sender, EventArgs e)
        {
            CadastrarFormaPagamento abrir = new CadastrarFormaPagamento();
            abrir.ShowDialog();
            CarregarListView();
        }

        private void TSBsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void TSBatualizar_Click(object sender, EventArgs e)
        {
            if (LVformaPagamento.SelectedItems.Count > 0)
            {

                CadastrarFormaPagamento teste = new CadastrarFormaPagamento(int.Parse(LVformaPagamento.SelectedItems[0].Text));
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
            if (LVformaPagamento.SelectedItems.Count > 0)
            {
                var opcao = MessageBox.Show("Deseja Realmente apagar essa Forma de Pagamento!!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    var id = int.Parse(LVformaPagamento.SelectedItems[0].Text);
                    Modelos.ClasseFormaPagamento chamar = new Modelos.ClasseFormaPagamento();
                    chamar.CarregarPorID(id);
                    chamar.DeletarFormaPagamento();
                    CarregarListView();

                }

            }
            else
            {
                MessageBox.Show("Forma de Pagamento não selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTpesquisa_Click(object sender, EventArgs e)
        {
            if (TBpesquisa.Text == string.Empty)
            {
                MessageBox.Show("Escreva o nome da Forma de Pagamento para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                CarregarListView();
            }
        }

        public void CarregarListView()
        {
            Conexao obj = new Conexao();
            LVformaPagamento.Items.Clear();
            try
            {
                string sql = $@"SELECT 
                                id_formaPagamento,
                                tipo_pagamento   
                                FROM FORMA_PAGAMENTO  
                                WHERE apagado = 0 AND tipo_pagamento LIKE '%{TBpesquisa.Text}%'";
                obj.conectar();

                SqlCommand cmd = new SqlCommand(sql, obj.objCon);
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    ListViewItem id = new ListViewItem();
                    ListViewItem.ListViewSubItem nome = new ListViewItem.ListViewSubItem();

                    id.Text = dr[0].ToString();
                    nome.Text = dr[1].ToString();
                    
                    id.SubItems.Add(nome);
                   
                    LVformaPagamento.Items.Add(id);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { obj.desconectar(); }



        }

        private void FormaPagamento_Load(object sender, EventArgs e)
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
