using System;
using System.Windows.Forms;
using Projeto_Restaurante.Modelos;

namespace Projeto_Restaurante
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void logar()
        {
            ClasseUsuario login = new ClasseUsuario();

            login.login = TB_usuario.Text;
            login.senha = TB_senha.Text;
            

            bool certo = login.logar();
            try
            {
                if (certo)
                {
                    login.CarregarUsuarioPorLogin(TB_usuario.Text);
                    if (login.cargo.id_cargo == 1)
                    {
                        Hide();
                        carregando teste = new carregando(login.cargo.id_cargo);
                        teste.ShowDialog();
                        Close();
                    }
                    else if (login.cargo.id_cargo == 2)
                    {
                        
                        Hide();
                        carregando teste = new carregando(login.cargo.id_cargo);
                        teste.ShowDialog();
                        Close();
                    }
                    else if (login.cargo.id_cargo == 3)
                    {
                        
                        Hide();
                        carregando teste = new carregando(login.cargo.id_cargo);
                        teste.ShowDialog();
                        Close();
                       
                    }
                    else if (login.cargo.id_cargo == 4)
                    {
                        MessageBox.Show("Acesso Negado!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
  
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha Invalidos! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro + "Erro Ocorrido");
            }
        }

        private void BT_logar_Click(object sender, EventArgs e)
        {
            try
            {
                Verificações.VerificarCampos.Validar(Controls);
                logar();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BT_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                logar();
            }
        }

        private void TB_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                logar();
            }
        }
    }
}
