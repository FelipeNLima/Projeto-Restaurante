using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Projeto_Restaurante
{
    using Conexão;

    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
            CarregarListView();
        }

        public void TSBadicionar_Click(object sender, EventArgs e)
        {
            CadastroUsuario abrir = new CadastroUsuario();
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
            listViewusuario.Items.Clear();
            try
            {
                string sql = $@"SELECT
                                id_usuario,
                                nome,
                                login,
                                CARGO.descricao 
                                FROM USUARIO 
                                INNER JOIN CARGO ON CARGO.id_cargo = USUARIO.id_cargo
                                WHERE apagado = 0 AND nome LIKE '%{TBpesquisa.Text}%'";
                obj.conectar();

                SqlCommand cmd = new SqlCommand(sql, obj.objCon);
                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    
                    ListViewItem id = new ListViewItem();
                    ListViewItem.ListViewSubItem nome = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem login = new ListViewItem.ListViewSubItem();
                    ListViewItem.ListViewSubItem cargo = new ListViewItem.ListViewSubItem();


                    id.Text = dr[0].ToString();
                    nome.Text = dr[1].ToString();
                    login.Text = dr[2].ToString();
                    cargo.Text = dr[3].ToString();

                    id.SubItems.Add(nome);
                    id.SubItems.Add(login);
                    id.SubItems.Add(cargo);

                    listViewusuario.Items.Add(id);

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

            if (listViewusuario.SelectedItems.Count > 0)
            {

                CadastroUsuario Abrir = new CadastroUsuario(int.Parse(listViewusuario.SelectedItems[0].Text));
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
            if(listViewusuario.SelectedItems.Count > 0)
            {
                var opcao = MessageBox.Show("Deseja Realmente apagar Usuario!!","Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcao == DialogResult.Yes)
                {
                    var id = int.Parse(listViewusuario.SelectedItems[0].Text);
                    Modelos.ClasseUsuario chamar = new Modelos.ClasseUsuario();
                    chamar.CarregarUsuarioPorId(id);
                    chamar.DeletarUsuario(id);
                    CarregarListView();

                }

            }
            else
            {
                MessageBox.Show("Garçom não selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Usuario_Load(object sender, EventArgs e)
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
                    MessageBox.Show("Escreva o nome do Usuario para pesquisar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

		private void TBpesquisa_KeyPress(object sender, KeyPressEventArgs e)
		{
			Verificações.Entradas usar = new Verificações.Entradas();
			usar.VerificaLetra(e);
		}
	}
}
