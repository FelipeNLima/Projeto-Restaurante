using System;
using Projeto_Restaurante.Modelos;

namespace Projeto_Restaurante_Comanda_Eletronica.Telas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void logar()
        {
            ClasseUsuario login = new ClasseUsuario();

            login.login = TBusuario.Text;
            login.senha = TBsenha.Text;


            bool certo = login.logar();
            if (certo)
            {
                    login.CarregarUsuarioPorLogin(TBusuario.Text);
                    if (login.cargo.id_cargo == 4)
                    {
                        Response.Redirect("~/Telas/Home.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Usuario com Acesso Não Permitido!');</script>");
                    }

                }
                else
                {
                    Response.Write("<script>alert('Usuario ou Senha Invalidos!');</script>");
                }
            }

        protected void BTentrar_Click(object sender, EventArgs e)
        {
            logar();
        }
    }
}