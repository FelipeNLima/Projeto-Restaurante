using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Projeto_Restaurante
{
    using Conexão;

    public partial class Garçom : Form
    {
        public Garçom()
        {
            InitializeComponent();
            CarregarListView();
        }

        public void TSBadicionar_Click(object sender, EventArgs e)
        {
            CadastroGarcon abrir = new CadastroGarcon();
            abrir.ShowDialog();
            CarregarListView();
            
        }

        private void TSBsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void CarregarListView()
        {
            Conexao obj = new Conexao();
            listViewgarcom.Items.Clear();
            try
            {
                string sql = $@"SELECT 
                                id_garcom,
                                nome_garcom,   
                                codigo 
                                FROM GARCOM  
                                WHERE apagado = 0 AND nome_garcom LIKE '%{TBpesquisa.Text}%'";
                obj.conectar();

                SqlCommand cmd = new SqlCommand(sql, obj.objCon);
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    ListViewItem id = new ListViewItem();
                    ListViewItem.ListViewSubItem nome = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem codigo = new ListViewItem.ListViewSubItem();


                    id.Text = dr[0].ToString();
                    nome.Text = dr[1].ToString();
                    codigo.Text = dr[2].ToString();

                    id.SubItems.Add(nome);
                    id.SubItems.Add(codigo);

                    listViewgarcom.Items.Add(id);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { obj.desconectar(); }



        }

        public void TSBeditar_Click(object sender, EventArgs e)
        {
            
            if(listViewgarcom.SelectedItems.Count > 0)
            {
                Modelos.ClasseGarcom x = new Modelos.ClasseGarcom();
                CadastroGarcon teste = new CadastroGarcon(int.Parse(listViewgarcom.SelectedItems[0].Text));
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
            if(listViewgarcom.SelectedItems.Count > 0)
            {
                var opcao = MessageBox.Show("Deseja Realmente apagar garçom!!","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    var id = int.Parse(listViewgarcom.SelectedItems[0].Text);
                    Modelos.ClasseGarcom chamar = new Modelos.ClasseGarcom();
                    chamar.CarregarPorId(id);
                    chamar.Deletargarcom();
                    CarregarListView();

                }

            }
            else
            {
                MessageBox.Show("Garçom não selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Garcon_Load(object sender, EventArgs e)
        {
           CarregarListView();
        }

        private void BTpesquisa_Click(object sender, EventArgs e)
        {
            if (TBpesquisa.Text == string.Empty)
            {
                MessageBox.Show("Escreva o nome do Garçom para pesquisar","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                CarregarListView();
            }
            
        }

		private void TBpesquisa_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaLetra(e);
		}
	}
}
