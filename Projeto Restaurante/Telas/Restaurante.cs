using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Restaurante.Telas
{
    using Conexão;
    public partial class Restaurante : Form
    {
        
        public Restaurante()
        {
            InitializeComponent();
        }

        private void TSBadicionar_Click(object sender, EventArgs e)
        {
            CadastroRestaurante abrir = new CadastroRestaurante();
            abrir.ShowDialog();
            CarregarListView();
        }

        private void TSBatualizar_Click(object sender, EventArgs e)
        {
            if (LVrestaurante.SelectedItems.Count > 0)
            {

                CadastroRestaurante teste = new CadastroRestaurante(int.Parse(LVrestaurante.SelectedItems[0].Text));
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
            if (LVrestaurante.SelectedItems.Count > 0)
            {
                var opcao = MessageBox.Show("Deseja Realmente apagar dados do Restaurante!!", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    var id = int.Parse(LVrestaurante.SelectedItems[0].Text);
                    Modelos.ClasseRestaurante chamar = new Modelos.ClasseRestaurante();
                    chamar.CarregarPorID(id);
                    chamar.DeletarRestaurante(id);
                    CarregarListView();

                }

            }
            else
            {
                MessageBox.Show("Restaurante não selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTpesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                Verificações.VerificarCampos.Validar(Controls);

                if (TBpesquisa.Text == string.Empty)
                {
                    MessageBox.Show("Escreva o nome do restaurante para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void TSBsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void CarregarListView()
        {
            Conexao obj = new Conexao();
            LVrestaurante.Items.Clear();
            try
            {
                string sql = $@"SELECT 
                                id_restaurante,
                                Nome_restaurante,
                                Nome_fantasia,
                                CNPJ,
                                IE,
                                Telefone,
                                email,
                                Endereco,
                                numero,
                                Cidade,
                                Estado,
                                cep  
                                FROM RESTAURANTE  
                                WHERE Nome_fantasia LIKE '%{TBpesquisa.Text}%'";

                obj.conectar();

                SqlCommand cmd = new SqlCommand(sql, obj.objCon);
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    ListViewItem id = new ListViewItem();
                    ListViewItem.ListViewSubItem nome = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem nome_fantasia = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem cnpj = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem ie = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem telefone = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem email = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem endereco = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem numero = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem cidade = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem estado = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem cep = new ListViewItem.ListViewSubItem();


                    id.Text = dr[0].ToString();
                    nome.Text = dr[1].ToString();
                    nome_fantasia.Text = dr[2].ToString();
                    cnpj.Text = dr[3].ToString();
                    ie.Text = dr[4].ToString();
                    telefone.Text = dr[5].ToString();
                    email.Text = dr[6].ToString();
                    endereco.Text = dr[7].ToString();
                    numero.Text = dr[8].ToString();
                    cidade.Text = dr[9].ToString();
                    estado.Text = dr[10].ToString();
                    cep.Text = dr[11].ToString();

                    id.SubItems.Add(nome);
                    id.SubItems.Add(nome_fantasia);
                    id.SubItems.Add(cnpj);
                    id.SubItems.Add(ie);
                    id.SubItems.Add(telefone);
                    id.SubItems.Add(email);
                    id.SubItems.Add(endereco);
                    id.SubItems.Add(numero);
                    id.SubItems.Add(cidade);
                    id.SubItems.Add(estado);
                    id.SubItems.Add(cep);

                    LVrestaurante.Items.Add(id);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { obj.desconectar(); }



        }

        private void Restaurante_Load(object sender, EventArgs e)
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
