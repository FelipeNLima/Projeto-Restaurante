using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Modelos.ClasseLogar login = new Modelos.ClasseLogar();

            login.usuario = TB_usuario.Text;
            login.senha = TB_senha.Text;
            bool certo = login.logar();
            try
            {
                if (certo)
                {
                    Hide();
                    Projeto_Restaurante.carregando teste = new carregando();
                    teste.ShowDialog();
                    Close();
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
            logar();
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


    }
}
