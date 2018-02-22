using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projeto_Restaurante
{
    using Conexão;

    public partial class CadastroUsuario : Form
    {
        bool cadastrar;
        int id;

        List<Modelos.ClasseCargo> lista = new List<Modelos.ClasseCargo>();
        public CadastroUsuario()
        {
            InitializeComponent();
            cadastrar = true;

        }

		// METODO PARA ATUALIZAR 
        public CadastroUsuario(int id)
        {
            InitializeComponent();
            this.id = id;
            CarregarDados();
            cadastrar = false;
            this.Text = "Editar Usuario";

        }

		// METODOS 
        public void cadastrarUsuario()
        {
            Modelos.ClasseUsuario usuario = new Modelos.ClasseUsuario();

            usuario.nome = TBnome.Text;
            usuario.login = TBlogin.Text;
            usuario.senha = TBsenha.Text;
            usuario.cargo = lista[CBcargo.SelectedIndex];
            usuario.apagado = false;


            bool certo = usuario.CadastrarUsuario();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Usuario cadastrada com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Usuario! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }

        }

        public void AtualizarUsuario()
        {
            Modelos.ClasseUsuario usuario = new Modelos.ClasseUsuario();

            usuario.id_usuario = id;
            usuario.nome = TBnome.Text;
            usuario.login = TBlogin.Text;
            usuario.senha = TBsenha.Text;
            usuario.cargo = lista[CBcargo.SelectedIndex];
            usuario.apagado = false; ;


            bool certo = usuario.AtualizarUsuario();
            try
            {
                if (certo)
                {
                    MessageBox.Show("Usuario atualizado com Sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao Atualizar Usuario! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }
        }

        public void CarregarDados()
        {
            Modelos.ClasseUsuario dados = new Modelos.ClasseUsuario();
            dados.CarregarUsuarioPorId(id);
            TBnome.Text = dados.nome;
            TBlogin.Text = dados.login;
        }

		public bool VerificaUsuario()
        {
            string login = TBlogin.Text;
            Modelos.ClasseUsuario verifica = new Modelos.ClasseUsuario();
            var tem = verifica.TemUsuario(login, id);

            if (tem)
            {

                MessageBox.Show("Login do Usuario ja existe! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;

        }

        private void TSBsair_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void TSBcadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Verificações.VerificarCampos.Validar(Controls);
                if (VerificaUsuario())
                {

                    if (cadastrar)
                    {
                        cadastrarUsuario();
                    }
                    else
                    {
                        AtualizarUsuario();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

		//VERIFICANDO ENTRADA

        private void TBnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            Verificações.Entradas usar = new Verificações.Entradas();
            usar.VerificaLetra(e);
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            lista = Modelos.ClasseCargo.ListaCarregarCargo();

            foreach (var item in lista)
            {
                CBcargo.Items.Add(item.descricao);
            }
        }
    }
}
